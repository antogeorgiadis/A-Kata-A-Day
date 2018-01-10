/**
* Level: 7kyu
* Description:
* Complete the findNextSquare method that finds the next integral perfect square after the one passed as a parameter.
* Recall that an integral perfect square is an integer n such that sqrt(n) is also an integer.
* If the parameter is itself not a perfect square, than -1 should be returned. You may assume the parameter is positive.
*/
function findNextSquare(sq) {
  let squareRoot = Math.sqrt(sq);
  let squareRootIsAWhole = squareRoot % 1 == 0;
  
  if (squareRootIsAWhole) {
    let nextPerfectSquare = squareRoot + 1;
    return nextPerfectSquare * nextPerfectSquare;
  }
  
  return -1;
}