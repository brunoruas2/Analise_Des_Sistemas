# -*- coding: utf-8 -*-
import os
import time

with open(r'E:\bruno\Meus Estudos\Meus_Estudos\Programação\_codes\input\texto.txt','r',encoding='utf-8') as texto:
	string = texto.read()

## functions
# funcao que retorna uma lista com o numero da entrada da string
def find_all(string,char):
	return [
		index
		for index in range(len(string) - len(char) + 1)
		if string[index:].startswith(char)
		]

def change_chars(str,char_in,char_out):
	index = find_all(string=str,char=char_in)
	n_index = len(index)
	if len(char_in) == 1:
		text = list(str)
		for i in range(n_index,0,-1):
			text = list(text)
			text[index[i-1]] = char_out
			text =''.join(text)
		return text
	else:
		text = str.replace(char_in,'@')
		text = list(str)
		for i in range(n_index,0,-1):
			text = list(text)
			text[index[i-1]] = char_out
			text =''.join(text)
		return text

# removendo quebras de linhas e outras marcas de edicao
for i in range(0,100):
	string = string.replace('$$','$')

for i in range(0,100):
	string = string.replace('\\section','\n\n\n\\section')

for i in range(0,100):
	string = string.replace('\\footnote','')

for i in range(0,100):
	string = string.replace('\\begin','')

for i in range(0,100):
	string = string.replace('\\end','')

string = change_chars(str=string,char_in='\n',char_out='')
string = change_chars(str=string,char_in='\\\\',char_out='')

# trocando '$' por '[latex]'
index = find_all(string=string,char='$')
n_index = len(index)
text = list(string)
for i in range(n_index,0,-1):
	if i % 2 == 0:
		text = list(text)
		text[index[i-1]] = '[/latex]'
		text =''.join(text)
	else:
		text = list(text)
		text[index[i-1]] = '[latex]'
		text =''.join(text)
string = text

# salvando o arquivo modificado
try:
	os.remove(r'E:\bruno\Meus Estudos\Meus_Estudos\Programação\_codes\input\texto_WP.txt')
except:
	time.sleep(0.1)

with open(r'E:\bruno\Meus Estudos\Meus_Estudos\Programação\_codes\input\texto_WP.txt','a',encoding='utf-8') as arquivo:
	arquivo.write(string)