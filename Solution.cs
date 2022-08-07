public class Solution {

    private readonly Dictionary<char, short> _singleValues = new Dictionary<char, short>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    
    public int RomanToInt(string romanNumber) {
        int sum = 0;
        short lastCharacterValue = 1001;
        
        for(byte characterIndex = 0; characterIndex < romanNumber.Length; characterIndex++){
            
            char currentChar = romanNumber[characterIndex];
            short currentCharValue = _singleValues[currentChar];
            byte nextCharacterIndex = (byte)(characterIndex + 1);
            
            if(nextCharacterIndex < romanNumber.Length &&
               currentCharValue < lastCharacterValue && 
               currentCharValue < _singleValues[romanNumber[nextCharacterIndex]]) {
                sum -= currentCharValue;
            }
            else 
            {
                sum += currentCharValue;
            }
            
            lastCharacterValue = currentCharValue;
        }
        return sum;
    }
}
