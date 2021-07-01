## Head Code ## 
class Book
    attr_accessor :title
	attr_accessor :author
	
	def initialize(title, author)
		raise 'You cannot instantiate an abstract class.'
	end
	
	def display
		raise 'You must override this method in your implementing class.'
	end
end

class MyBook < Book
	attr_accessor :price

    ## Solution Code ##
    #   Class Constructor
	#   
	#   Parameters:
	#   title - The book's title.
	#   author - The book's author.
	#   price - The book's price.
	def initialize(title, author, price)
		@title = title
		@author = author
		@price = price
	end
	
	#   Function Name: display
	#   Print the title, author, and price in the specified format.
	#
	def display()
	    print("Title: ", self.title, "Author: ", self.author, "Price: ", self.price)
	end
end

## Tail Code ##

title = gets
author = gets
price = gets

new_novel = MyBook.new(title, author, price)
new_novel.display    