#### Is there a way to do this
# @color[#DC143C](WITHOUT)
## reflection?

---

# @color[#DC143C](YES)
@emoji[eyes]

---

@snap[fragment]
#### A
@snapend

@snap[fragment]
### @color[#DC543C](REALLY)
@snapend

@snap[fragment]
## @color[#DCA43C](BIG)
@snapend

@snap[fragment]
# @color[#DC143C](SWITCH)
@snapend

---

@transition[none]

@code[cs zoom-06](sections/implementing-without-reflection/code/F_method.cs)

@[3](Handle @color[#DC143C](empty) or @color[#DC143C](null) strings @emoji[punch]))
@[5](Create a local variable to store the @color[#DC143C](result))
@[6](Create a local variable to store the @color[#DC143C](match) so we can use in it in our `while` loop below)
@[7](Find a @color[#DC143C](match) in the string)
@[9](Get the @color[#DC143C](value) from invoking the method for the faker)
@[10-13](Inject the new value between the @color[#DC143C](start) and @color[#DC143C](end) and update the @color[#DC143C](result))
@[7-14](Continue doing this until no more matches are found)
@[16](Return the @color[#DC143C](result))
@[6](What does @color[#DC143C](`FakerMatch`) look like?)

---
@transition[none]

@code[cs zoom-07](sections/implementing-without-reflection/code/FakerMatch.cs)

@[3](Did we get a @color[#DC143C](successful) match?)
@[4](If we did, where is the @color[#DC143C](start)?)
@[5](How @color[#DC143C](long) was the match?)
@[6](What @color[#DC143C](name) did we find?)
@[7](What @color[#DC143C](method) did we find?)

---
@transition[none]

@code[cs zoom-07](sections/implementing-without-reflection/code/F_method.cs)

@[7]

---
@transition[none]

@code[cs zoom-07](sections/implementing-without-reflection/code/ExtractMatchFrom_method.cs)

@[3](Example: @color[#DC143C]({Name.FirstName}))
@[1,4](Check if we find a @color[#DC143C](match) in `input`)
@[6](Were we successful?)
@[7-14](@color[#DC143C](Yes))
@[9](Set @color[#DC143C](Success) to true (for our `while` loop))
@[10-11](Extract the @color[#DC143C](Index) and @color[#DC143C](Length) from the @color[#DC143C](match))
@[12](Extract the first capture for the @color[#DC143C](Name))
@[13](Extract the second capture for the @color[#DC143C](Method))
@[15](If there was @color[#DC143C](no match) then return the default `FakerMatch`)
@[15](`Success` will automatically set to @color[#DC143C](`false`))

---
@transition[none]

@code[cs zoom-07](sections/implementing-without-reflection/code/F_method.cs)

@[9]

---
@transition[none]

@code[cs zoom-07](sections/implementing-without-reflection/code/GetValue_method.cs)

@[3](Holds our @color[#DC143C](output) value)
@[4](Convert the faker to @color[#DC143C](lower case))
@[6](Have a case for @color[#DC143C](each faker name))
@[7](Get the @color[#DC143C](value) from that particular faker)
@[11](Or throw an exception when the faker @color[#DC143C](doesn't exist))
@[14](Return the value)
@[15](Or throw an exception if we got a @color[#DC143C](`null`))
@[15](This signifies when the method @color[#DC143C](does not exist) for the faker)

---
@transition[none]

@code[cs zoom-06](sections/implementing-without-reflection/code/GetValueForNameFaker_method.cs)

@[3](Convert the method to @color[#DC143C](lower case))
@[5, 8, 11, 14](Have a case for @color[#DC143C](each method))
@[6](Return the @color[#DC143C](value) from executing the method)
@[17](Or when that method @color[#DC143C](does not exist))
@[18](Return @color[#DC143C](`null`))

---
@transition[none]

@code[cs zoom-07](sections/implementing-without-reflection/code/F_method.cs)

@[10-13](@color[#DC143C](Inject) the returned value)
@[16](@color[#DC143C](Return) when we are finished)
