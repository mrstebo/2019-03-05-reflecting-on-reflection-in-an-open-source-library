#### What if we add
# @color[#DC143C](ANOTHER)
### module
## ???
@emoji[thinking_face]

---

@snap[fragment]
#### Looks like we'll need a
# @color[#DC143C](BIGGER)
### switch statement
@snapend

@snap[fragment]
@emoji[see_no_evil]
@snapend

---
@transition[none]

@code[cs zoom-05](sections/extending-without-reflection/code/GetValue_method.cs)

@[6-8]

---
@transition[none]

@code[cs zoom-05](sections/extending-without-reflection/code/GetValueForAppFaker_method.cs)

@[5, 8, 11](Handling all the @color[#DC143C](methods))
@[6, 9, 12](And returning their @color[#DC143C](values))

---
@transition[none]

@code[cs zoom-05](sections/extending-without-reflection/code/GetValue_method.cs)

@[14-16]

---
@transition[none]

@code[cs zoom-05](sections/extending-without-reflection/code/GetValueForUniversityFaker_method.cs)

@[5, 8, 11, 14, 17](Handling all the @color[#DC143C](methods))
@[6, 9, 12, 15, 18](And returning their @color[#DC143C](values))

---

## Why is this a
# @color[#DC143C]("BAD")
## approach?

@emoji[thinking_face]

---

### We have to
# @color[#DC143C](MODIFY)
## the `FakeFaker` class
#### every time we add a new faker

---

### The `FakeFaker` class will get
## @color[#DC143C](BIGGER)
#### and
# @color[#DC143C](BIGGER)

---

### Someone may
# @color[#DC143C](MISS)
#### a method

---

## There could be
# @color[#DC143C](TYPOS)
### in the switch statement

---

@snap[fragment]
## Granted...
@snapend

@snap[fragment]
### @color[#DC143C](Unit tests) should find the last two issues
@emoji[sweat_smile]
@snapend

---

@snap[fragment north]
### But really...
@snapend

@snap[fragment]
#### Is this
@snapend

@snap[fragment]
## @color[#DC143C](MANAGEBLE)
@snapend

---

@snap[fragment]
### We can improve this using
@snapend

@snap[fragment]
# @color[#DC143C](REFLECTION)
@emoji[raised_hands]
@snapend