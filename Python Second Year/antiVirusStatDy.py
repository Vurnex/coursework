import clamd
import sys
import inspect

def staticAnalysis():
	cd = clamd.ClamdUnixSocket()

	print(cd.ping())

	print(cd.version())
	
	#open('/tmp/EICAR','wb').write(clamd.EICAR)

	print(cd.scan('/home/seed/Downloads/eicar_com.zip'))
	
staticAnalysis()
















