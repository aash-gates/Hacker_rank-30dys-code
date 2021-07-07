// This is a little cleaner
import Foundation
import Darwin

let numStrings = Int(readLine()!)!

func printEveryOther(charArray: [String], startIndex: Int) {
    var index = startIndex
    while index < charArray.count {
        print(charArray[index], terminator: "")
        index = index + 2
    }
}

func printEvenAndOdd(string: String) {
    // This prints inputString to stderr for debugging:
    fputs("string: " + string + "\n", stderr)
    
    let chars = string.characters.map { String($0) }
    printEveryOther(charArray: chars, startIndex: 0)
    print(" ", terminator: "")
    printEveryOther(charArray: chars, startIndex: 1)
    print()
}

for _ in 1...numStrings {
    let inputString = readLine()!
    printEvenAndOdd(string: inputString)
}