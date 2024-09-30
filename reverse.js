function solution(str) {
  //split reverse join
  str = str.split('')
  str = str.reverse()
  return str.join('')
}
// Pass in the following:
//
// const chai = require("chai");
// const assert = chai.assert;
// chai.config.truncateThreshold=0;

// describe("Basic tests", () => {
//   it("Testing for fixed tests", () => {
//     assert.strictEqual(solution('world'), 'dlrow');
//     assert.strictEqual(solution('hello'), 'olleh');
//     assert.strictEqual(solution(''), '');
//     assert.strictEqual(solution('h'), 'h');
//   });
// });




// In hindsight I could have done it all on one line.
// ex.
// function solution (str){
// return str.split('').reverse().join('')
//}