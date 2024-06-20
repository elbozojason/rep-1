from datetime import datetime
now = datetime.now()
if("%H,%M,%S">"15,47,00"):
    keterangan = 'tepat waktu'
else:
    keterangan = 'telat'
identity = 0
while identity != 'exit':
    identity = input('N.I.S=')
    file = open(now.strftime("%Y-%m-%d.txt"),"r")
    condition = (file.read().find(identity))
    
    file.close
    
    if condition == -1 and identity != 'exit':
        file = open(now.strftime("%Y-%m-%d.txt"),"a")
        file.write(identity+','+'in'+','+now.strftime("%Y-%m-%d")+','+now.strftime("%H:%M:%S")+','+keterangan+'\n')
        file.close()
    elif identity == 'exit':
        file = open(now.strftime("%Y-%m-%d.txt"),"a")
        file.write(identity)
        file.close()
    else:
        print('already logged in, el bozo!')