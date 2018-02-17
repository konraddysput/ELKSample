import random
from datetime import datetime, date, time, timedelta
from time import sleep

user = ['konrad', 'tiger', 'nno44', 'blue_sky']
arr = [' join a chanel', 'create new event', 'cancel event', 'logout from server', 'receive new message' ]

def period_log():
    while True:
        print(user[random.randint(0, len(user) - 1)] + " " + arr[random.randint(0, len(arr) - 1)])
        sleep(1)

if __name__ == "__main__":
    period_log()