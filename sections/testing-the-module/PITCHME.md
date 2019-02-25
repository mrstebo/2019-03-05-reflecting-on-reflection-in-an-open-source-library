### How do we make sure it works?

---

## BY
# WRITING
### @color[#DC143C](UNIT TESTS)
#### @emoji[tada]

---

# @color[#92F11A](NUnit)

@snap[south fragment]
[https://nunit.org/]()
@snapend

---

# @color[#FCE41C](FakeItEasy)

@snap[south fragment]
[https://fakeiteasy.github.io/]()
@snapend
---

@code[cs zoom-06](sections/testing-the-module/code/FakeFakerTests.cs)

@[2, 4](The tests are using @color[#92F11A](NUnit) and @color[#FCE41C](FakeItEasy))
@[15, 19](We create a @color[#DC143C](mock) instance of the @color[#DC143C](`IFakerContainer`))
@[16,20](We @color[#DC143C](inject) the mock into the @color[#DC143C](`FakeFaker`) instance)
@[32-41](It @color[#DC143C](replaces the placeholders) with calls to the faker methods)
@[22-30](It handles @color[#DC143C](duplicates))
@[43-52](It is @color[#DC143C](case-insensitive))
@[54-60](It handles @color[#DC143C](empty strings))
@[82-86](It handles @color[#DC143C](null))
@[62-70](It @color[#DC143C](throws an error) if it can't find the faker module)
@[72-80](And it @color[#DC143C](throws an error) if it can't find the method on the faker module)
