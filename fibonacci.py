def fibonacci(c): 
	a = 0
	b = 1
	 
	if c == 0: 
		return a 
	elif c == 1: 
		return b 
	else: 
		for i in range(2,c): 
			d = a + b 
			a = b 
			b = d 
		return b
        
    