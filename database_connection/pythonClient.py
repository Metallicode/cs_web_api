import requests
import matplotlib.pyplot as plt

response = requests.get("http://localhost:8080/api/values")
responseList = response.json()

lengthsList = []

for i in range(len(responseList)):
     lengthsList.append(len(responseList[i]["Text"]))

plt.plot(lengthsList)
plt.show()
