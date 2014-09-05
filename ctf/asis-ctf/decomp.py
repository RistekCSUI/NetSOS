#!/usr/bin/env python

# ASIS-CTF Random Image problem

import Image
import random

def get_color(x, y, r):
	n = (pow(x, 3) + pow(y, 3)) ^ r
	return (n ^ ((n >> 8) << 8 ))


flag_img = Image.open("enc.png")
im = flag_img.load()

enc_img = Image.new(flag_img.mode, flag_img.size)
enpix = enc_img.load()

for x in range(flag_img.size[0]):
	for y in range(flag_img.size[1]):
		#if im[x,y] < 250 :
		enpix[x,y] = get_color(x,y,im[x,y])


enc_img.save('deber'+'.png');
