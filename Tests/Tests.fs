namespace CS220

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.A``() =
    let r = Program.countOccurrence "my name is Ann" "n"
    Assert.AreEqual (3UL, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.B``() =
    let r = Program.countOccurrence "Hello FSharp World" "A"
    Assert.AreEqual (0UL, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.C``() =
    let r = Program.countOccurrence "131311313313131331333313" "13"
    Assert.AreEqual (9UL, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.D``() =
    let r = Program.countOccurrence "1111111" "11"
    Assert.AreEqual (6UL, r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.A``() =
    let r = Program.rotate [ 1; 2; 3; 4 ] 4
    Assert.AreEqual ([ 1; 2; 3; 4 ], r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.B``() =
    let r = Program.rotate [ 1; 2; 3; 4 ] -2
    Assert.AreEqual ([ 3; 4; 1; 2 ], r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.C``() =
    let r = Program.rotate [ 'a'; 'b'; 'c'; 'd' ] 3
    Assert.AreEqual ([ 'b'; 'c'; 'd'; 'a' ], r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.D``() =
    let r = Program.rotate [ 1; 2 ] 9
    Assert.AreEqual ([ 2; 1 ], r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.E``() =
    let r = Program.rotate [ "A"; "B"; "C" ] 0
    Assert.AreEqual ([ "A"; "B"; "C" ], r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.A``() =
    let matrix = Program.SqMatrix.init [ [ 3; 1; 1 ]; [ 1; 3; 1 ]; [ 1; 1; 3 ] ]
    let r = Program.diagonal matrix
    Assert.AreEqual ([ 3; 3; 3 ], r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.B``() =
    let matrix = Program.SqMatrix.init [ [ "ABC" ] ]
    let r = Program.diagonal matrix
    Assert.AreEqual ([ "ABC" ], r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.C``() =
    let matrix =
      Program.SqMatrix.init
      <| [ [ 3; 1; 1; 1 ]; [ 1; 3; 1; 1 ]; [ 1; 1; 3; 1 ]; [ 1; 1; 1; 3 ] ]
    let r = Program.diagonal matrix
    Assert.AreEqual ([ 3; 3; 3; 3 ], r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.A``() =
    let matrix = Program.SqMatrix.init [ [ 3; 1; 1 ]; [ 1; 3; 1 ]; [ 1; 1; 3 ] ]
    let r = Program.transpose matrix
    Assert.AreEqual (matrix, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.B``() =
    let matrix = Program.SqMatrix.init [ [ 3; 2 ]; [ 1; 2 ] ]
    let r = Program.transpose matrix
    let ans = Program.SqMatrix.init [ [ 3; 1 ]; [ 2; 2 ] ]
    Assert.AreEqual (ans, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.C``() =
    let matrix = Program.SqMatrix.init [ [ 3; 2 ]; [ 1; 2 ] ]
    let r = Program.transpose matrix
    let ans = Program.SqMatrix.init [ [ 3; 1 ]; [ 2; 2 ] ]
    Assert.AreEqual (ans, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.D``() =
    let matrix =
      Program.SqMatrix.init [ [ 1 ; 2 ; 3 ] ; [ 4 ; 5 ; 6 ] ; [ 7 ; 8 ; 9 ] ]
    let r = Program.transpose matrix
    let ans =
      Program.SqMatrix.init [ [ 1 ; 4 ; 7 ] ; [ 2 ; 5 ; 8 ] ; [ 3 ; 6 ; 9 ] ]
    Assert.AreEqual (ans, r)

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.A``() =
    let r = Program.hanoi 1 2 2
    Assert.AreEqual ([ (1, 3); (1, 2); (3, 2) ], r)

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.B``() =
    let r = Program.hanoi 3 1 4
    let ans =
      [ (3, 2); (3, 1); (2, 1); (3, 2); (1, 3); (1, 2); (3, 2); (3, 1)
        (2, 1); (2, 3); (1, 3); (2, 1); (3, 2); (3, 1); (2, 1) ]
    Assert.AreEqual (ans, r)

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.C``() =
    let r = Program.hanoi 2 3 5
    let ans =
      [ (2, 3); (2, 1); (3, 1); (2, 3); (1, 2); (1, 3); (2, 3); (2, 1)
        (3, 1); (3, 2); (1, 2); (3, 1); (2, 3); (2, 1); (3, 1); (2, 3)
        (1, 2); (1, 3); (2, 3); (1, 2); (3, 1); (3, 2); (1, 2); (1, 3)
        (2, 3); (2, 1); (3, 1); (2, 3); (1, 2); (1, 3); (2, 3) ]
    Assert.AreEqual (ans, r)
