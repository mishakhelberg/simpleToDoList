function disemvowel(str) {
    let brokenString = str.split('')  
    const map1 = brokenString.map(x => x === 'a'|| x === 'e' || x === 'i'||x === 'o'||x === 'u' || x === 'A'|| x === 'E' || x === 'I'||x === 'O'||x === 'U'? x = '': x = x);
    let noVowels = map1.join("")
    return noVowels
  }


  //or...

  function disemvowel(str) {
    return str.replace(/[aeiou]/gi, '');
  }

// //sample tests
// const { assert } = require("chai")

// describe("Basic tests", () => {
//   it("Testing for fixed tests", () => {
//     assert.strictEqual(disemvowel("This website is for losers LOL!"), "Ths wbst s fr lsrs LL!")
//     assert.strictEqual(disemvowel("No offense but,\nYour writing is among the worst I've ever read"), "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd")
//     assert.strictEqual(disemvowel("What are you, a communist?"), "Wht r y,  cmmnst?")
//     })
//   })
