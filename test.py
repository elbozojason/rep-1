from datetime import date
from datetime import datetime
today = date.today()
print("Today's date:", today)

now = datetime.now()
 
print("now =", now.strftime("%d/%m/%Y %H:%M:%S:1"))                   