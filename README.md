# BaselessConv
Converts Base Combination of Chars to Int and back to String combination of the base chars.

### Combinations versus precision encoding accuracy

This tool for Baseless Conversions is basically a way to switch to a given base and then find unique combinations of characters.  

#### Using this base for example:
`abc`  - BASE

#### Would yield this set of combinations

`
a
b
c
aa
ab
ac
ba
bb
bc
ca
cb
cc
aaa
`
etc...

### Numbers equal Combination and Combination equals a number

`a - 1`
`b - 2`
`c - 3`
`aa - 4` 
`ab - 5`
`ac - 6`
`ba - 7`
`bb - 8`
`bc - 9`
`ca - 10`
`cb - 11`
`cc - 12`
`aaa - 13`
etc...

### Can enter a number with one method and get a combination and vice versa

So once you establish a base of unique characters (you're not limited to one base - so the reason for the name of this project) to use you can then go between the combination and the number.   It uses a double instead of an int so as long as your combination does not go over that amount of the max value of a double your combinations can be quite big.

This tool does not offer precision in terms of actual hex values.  Instead it displays only the correct correlation in the combination of characters to a numerical represenation.  And given that numerical representation it is possible to derice or arrive back at the original combination.

Some possible uses for this tool include compression, obfuscation, converting sections of a url to a smaller url.  Creating unique combinations of characters and then hiding data in numerical sequences to prevent access to sensitive data.

Each encoding does require a unique set of characters.  No character should repeat... and if the character does repeat you are left to your own devices in interpreting the meaning of the data.

The size of the combinations in terms of a number are 1* 10 to the 18th power.  That translates into different sizes for different combinations of characters.  Base64 would only allow for up to 10 character combinations before maxing out this number.  So sequences of 10 characters would have to repeat if you continued to use this combination to obfuscate or create small set of urls.  

If you started with one and worked your way up to the highest number it would translate into different combinations of the set of sequences and that sequence could also be analyzed and the original number arrived at.

Its up to the developer to determine how to stitch sections back togeher in a meaningful way.

Compression could be used to convert to a number sequence from words.  And then from the number sequence that could be further compressed.

The most powerful mechanism for compression would be to convert to integer dictionary that then is converted to a code, which is then further compressed.

This could go on serveral times and the original content could be retrieved by reversing the process.

The algorithm for generating these combinations are not technically unique numerical numbers.  For instance by having a 0... if you have several leading zeros like 0001  or 1 or 001  each one of these are the same number.  But combinations of the characters have a totally different meaning and actually translate into a different number.  As long as you realize that then this tool is rather straigh forward.

### Base of characters should not contain repeating chars.

#### Warning

<p style="color: red;">If you put in a base of characters which contain repeating characters it will not go between numbers and combinations in expected ways.   So you should always limit the base of characters used to create your combination in the array to only unique characters.</p>
