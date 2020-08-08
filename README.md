# BaselessConv
Converts Base to Int and back to String

### Combinations versus precision encoding accuracy

This tool for Baseless Conversions is basically a way to switch to a given base and then find unique combinations of characters.  

#### Example
`abc`

This combination would yield this set of combinations

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
