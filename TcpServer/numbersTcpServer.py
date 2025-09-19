from socket import *
import threading
import json
import random

serverport = 15838
serverSocket = socket(AF_INET, SOCK_STREAM)
serverSocket.bind(('', serverport))
serverSocket.listen(3) # 3 Clients can access the server at a time
print("Server is ready to recieve")

### Client Input 
# random 1 10
# add 2 5
# subtract 5 3

def numOperationService(connectionSocket):
    """
    Service for clients to perform the following number operations: 
    random - gives a random number between the two arguments given
    add - gives the sum of the two arguments
    subtract - gives the difference of the two arguments
    NB: The client must provide the input arguments as integers
    """
    while True:
        message = connectionSocket.recv(1024).decode().strip()
        if message == "exit":
            break
        msg = message.lower().split()
        if msg[0] == "random":
            num1 = int(msg[1])
            num2 = int(msg[2])
            result = random.randint(num1, num2)
            outMessage = str(result) + "\n"
            connectionSocket.send(outMessage.encode())
        elif msg[0] == "add":
            num1 = int(msg[1])
            num2 = int(msg[2])
            sum = num1 + num2
            outMessage = str(sum) + "\n"
            connectionSocket.send(outMessage.encode())
        elif msg[0] == "subtract":
            num1 = int(msg[1])
            num2 = int(msg[2])
            diff = num1 - num2
            outMessage = str(diff) + "\n"
            connectionSocket.send(outMessage.encode())

### Client Input
# {"random":{"num1":1, "num2":10}}
# {"add":{"num1":2,"num2":5}}
# {"subtract":{"num1":5, "num2":3}}

def numOperationJsonService(connectionSocket):
    """
    Service for clients to perform the following number operations:
    random - gives a random number between the two input arguments
    add - gives the sum of the two input arguments
    subtract - gives the sum of the two input arguments
    NB: For this service, the client must provide the whole input in json format
    NB: The client must provide the input arguments as integers
    """
    while True:
        message = connectionSocket.recv(1024).decode().strip()
        if message == "exit":
            break
        try:
            msg = json.loads(message)
            keyList = list(msg.keys())
            if keyList[0] == "random":
                args = msg["random"]
                print(args)
                num1 = int(args["num1"])
                num2 = int(args["num2"])
                result = random.randint(num1, num2)
                outMessage = str(result) + "\n"
                connectionSocket.send(outMessage.encode())
            elif keyList[0] == "add":
                args = msg["add"]
                num1 = int(args["num1"])
                num2 = int(args["num2"])
                sum = num1 + num2
                outMessage = str(sum) + "\n"
                connectionSocket.send(outMessage.encode())
            elif keyList[0] == "subtract":
                args = msg["subtract"]
                print(args)
                num1 = int(args["num1"])
                num2 = int(args["num2"])
                diff = num1 - num2
                outMessage = str(diff) + "\n"
                connectionSocket.send(outMessage.encode())
        except json.JSONDecodeError:
            print("Invalid input format - must be in JSON format")
            break

while True:
    connectionSocket, addr = serverSocket.accept()
    print(f"Connection established with {addr}")
    #threading.Thread(target=numOperationService, args=(connectionSocket,)).start()
    threading.Thread(target=numOperationJsonService, args=(connectionSocket,)).start()
    break