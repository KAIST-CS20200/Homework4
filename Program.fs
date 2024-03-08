module CS220.Program

/// Write a function `countOccurrence` that takes in a string `haystack` and a
/// string `needle`, and returns the number of times `needle` occurs in
/// `haystack`. For example, if "abcabc" and "ab" are given, the function should
/// return 2.
let countOccurrence (haystack: string) (needle: string) =
  failwith "TODO" // REMOVE this line when you implement your own code

/// Write a function `rotate` that takes in a list `lst` and an integer `n`, and
/// returns a new list with the elements of `lst` rotated `n` times either to
/// the left or to the right depending  on the sign of `n`. When `n` is
/// positive, the rotation is to the right, and when `n` is negative, the
/// rotation is to the left. For example, if the list is [1; 2; 3; 4; 5] and
/// `n` is 2, the function should return [4; 5; 1; 2; 3].
let rotate lst n =
  failwith "TODO" // REMOVE this line when you implement your own code

/// We represent a matrix as a list of lists. Each sublist represents a row of
/// the matrix. For example, the matrix `[ [1; 2; 3]; [4; 5; 6]; [7; 8; 9] ]` is
/// a 3x3 matrix, where the first row is `[1; 2; 3]`, the second row is `[4; 5;
/// 6]`, and so on.
type SqMatrix<'T> = 'T list list

module SqMatrix =
  /// This is a helper function to create a square matrix from a list of lists.
  let init (rows: 'a list list): 'a SqMatrix =
    match rows with
    | [] -> []
    | _ ->
      let len = List.length rows
      let equalSize = rows |> List.forall (fun row -> List.length row = len)
      if equalSize then rows else failwith "Not a square matrix"

/// Write a function `diagonal` that takes in a square matrix and returns a list
/// containing the elements of the main diagonal of the matrix. The main diagonal
/// of a matrix is the list of elements that starts at the top-left corner of the
/// matrix and ends at the bottom-right corner. We assume that SqMatrix type is
/// always well-formed because it is always created using the `SqMatrix.init`
/// function.
let diagonal (matrix: SqMatrix<_>) =
  failwith "TODO" // REMOVE this line when you implement your own code

/// Write a function `transpose` that takes in a square matrix and returns a new
/// matrix that is the transpose of the input matrix. The transpose of a matrix
/// is obtained by swapping the rows and columns of the matrix.
let transpose (matrix: SqMatrix<_>) =
  failwith "TODO" // REMOVE this line when you implement your own code

/// Write a function `hanoi` that takes in three integers `startPos`, `endPos`,
/// and `n`, and returns a list of tuples representing the sequence of moves
/// needed to solve the Tower of Hanoi puzzle with `n` disks. The parameters
/// `startPos` and `endPos` are the positions of the pegs and they are 1, 2, or
/// 3. The goal of this game is to move the `n` disks from the peg at `startPos`
/// to the peg at `endPos` using the peg at the remaining position. The
/// returning list of tuples should contain the sequence of moves needed to
/// solve the puzzle. The following rules should be followed when playing the
/// game:
/// - Only one disk can be moved at a time.
/// - Each move consists of taking the top (smallest) disk from one of the rods
///   and sliding it onto another rod, on top of the other disks that may already
///   be present on that rod.
/// - No disk may be placed on top of a smaller disk.
/// This function should return an optimal solution, which is a minimal list of
/// moves to make. Each move is represented as a tuple of two integers, where the
/// first integer is the position of the peg from which the disk is moved, and
/// the second integer is the position of the peg to which the disk is moved.
/// For example, a pair (1, 2) means that the disk is moved from the first peg to
/// the second peg.
let hanoi startPos endPos n =
  failwith "TODO" // REMOVE this line when you implement your own code

[<EntryPoint>]
let main _args =
  0
