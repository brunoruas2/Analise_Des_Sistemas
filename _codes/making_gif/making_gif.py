# fonte: https://towardsdatascience.com/basics-of-gifs-with-pythons-matplotlib-54dd544b6f30
import os
import imageio

path = r'C:\Users\bruno\Documents\Metadata\Meus_Estudos\Programação\_codes\making_gif\input'
filenames = os.listdir(r'C:\Users\bruno\Documents\Metadata\Meus_Estudos\Programação\_codes\making_gif\input')
with imageio.get_writer(r'C:\Users\bruno\Documents\Metadata\Meus_Estudos\Programação\_codes\making_gif\ouput\mygif.gif', mode='I') as writer:
		for filename in filenames:
			for i in range(0,20):
					image = imageio.imread('{}\{}'.format(path,filename))
					writer.append_data(image)
