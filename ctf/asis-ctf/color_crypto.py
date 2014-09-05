#!/usr/bin/env python

import Image
import random

def get_color(x, y, r):
	n = (pow(x, 3) + pow(y, 3)) ^ r
	return (n ^ ((n >> 8) << 8 ))

flag_img = Image.open("flag.png")
im = flag_img.load()
r = random.randint(1, pow(2, 256))
print flag_img.size

enc_img = Image.new(flag_img.mode, flag_img.size)
enpix = enc_img.load()

for x in range(flag_img.size[0]):
	for y in range(flag_img.size[1]):
		t = random.randint(1, pow(2, 256)) % 250
		enpix[x,y] = t


for x in range(flag_img.size[0]):
	for y in range(flag_img.size[1]):
		if im[x,y] < 250 :
			s = get_color(x, y, r)
			enpix[x,y] = s
		
enc_img.save('enc' + '.png')
