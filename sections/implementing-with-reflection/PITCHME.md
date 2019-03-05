### And the same again
#### using
# @color[#DC143C](REFLECTION)

---

@code[cs zoom-07](sections/implementing-with-reflection/code/F_method.cs)

@[3](Handle @color[#DC143C](empty) or @color[#DC143C](null) strings @emoji[punch])

@[5](Create a local variable to store the @color[#DC143C](result))
@[6](Create a local variable to store the @color[#DC143C](match) so we can use in it in our `while` loop below)
@[7](Find a @color[#DC143C](match) in the string)
@[9](Create an instance of the specific @color[#DC143C](faker) class)
@[10](Get the @color[#DC143C](value) from invoking the specific method on the faker class)
@[11-14](Inject the new value between the @color[#DC143C](start) and @color[#DC143C](end) and update the @color[#DC143C](result))
@[7-15](Continue doing this until no more matches are found)
@[17](Return the @color[#DC143C](result))

---
@transition[none]

@code[cs zoom-07](sections/implementing-with-reflection/code/F_method.cs)

@[7]

---
@transition[none]

@code[cs zoom-07](sections/implementing-with-reflection/code/ExtractMatchFrom_method.cs)

@[](Nothing new here)

---
@transition[none]

@code[cs zoom-07](sections/implementing-with-reflection/code/F_method.cs)

@[9](We have added this @color[#DC143C](new) method @emoji[open_mouth])

---
@transition[none]

@code[cs zoom-06](sections/implementing-with-reflection/code/GetFaker_method.cs)

@[3]
@[3](@color[#DC143C](IgnoreCase) means we can do a case-insensitive search for the property)
@[3](@color[#DC143C](Public) means public members are included in the search)
@[3](@color[#DC143C](Instance) means instance members are to be included in the search)
@[5](@emoji[tada])
@[6](@emoji[boom])

---
@transition[none]

@code[cs zoom-07](sections/implementing-with-reflection/code/F_method.cs)

@[10]

---
@transition[none]

@code[cs zoom-06](sections/implementing-with-reflection/code/GetValue_method.cs)

@[3](The same flags as the previous method)
@[4](@emoji[tada])
@[5](@emoji[boom])
@[7](Some methods @color[#DC143C](require parameters))
@[7, 13-18](So we use the @color[#DC143C](`DefaultValue`) method)
@[15-16](If the parameter is a @color[#DC143C](ValueType) then we need to create an instance of it)
@[17](Otherwise we can return @color[#DC143C](null))
@[8](Invoke the method on the @color[#DC143C](`_fakerContainer`) with those parameters @emoji[point_up])
@[10](Convert the returning value into a @color[#DC143C](string))

---
@transition[none]

@code[cs zoom-07](sections/implementing-with-reflection/code/F_method.cs)

@[11-14](@color[#DC143C](Inject) the returned value)
@[17](@color[#DC143C](Return) when we are finished)
