class MyBook extends Book {
    
    constructor(title, author, price) {
        super(title, author)
        this.price = price
    }
    
    display() {
        console.log(
            'Title: ' + this.title + '\n' +
            'Author: ' + this.author + '\n' +
            'Price: ' + this.price
        )
    }
}