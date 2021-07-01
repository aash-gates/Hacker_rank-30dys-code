import Foundation

class Difference {
    private var elements = [Int]()
    var maximumDifference: Int
	 init(a : [Int]) {
        self.elements = a
        self.maximumDifference = 0
    }

    /** Sorts the array
    *   Saves max abs difference between first and last element to maximumDifference. **/
    func computeDifference() {
        self.elements = self.elements.sorted()
        self.maximumDifference = elements[elements.count - 1] - elements[0]
    }

} // End of Difference class