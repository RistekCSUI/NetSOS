from socket import * 

host = "192.168.91.100"            
s = socket(AF_INET, SOCK_DGRAM)

for port in range(10,65535):
	try:
		data = "Hello"
		#print "Try "+str(port)
		s.sendto(data,(host,port))
		s.settimeout(0)
		print ((s.recvfrom(1024)))
		break
	except:
		pass
                        