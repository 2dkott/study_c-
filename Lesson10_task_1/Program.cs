bool isFirstCharVowel(string stringValue) { 
    string vowels = "aeiouy";
    return vowels.Contains(stringValue[0]) ? true : false;
}

int countWordsWithFirstVowel(string[] stringArray) {
    int counter = 0;
    for (int i=0; i < stringArray.Length; i++) {
        if (isFirstCharVowel(stringArray[i])) counter += 1; 
    }
    return counter;
}

string[] testArray = new string[] { "qwe", "wer", "ert", "rty", "tyu" };
Console.Write(countWordsWithFirstVowel(testArray));
