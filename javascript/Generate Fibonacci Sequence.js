/**
 * @return {Generator<number>}
 */
var fibGenerator = function* () {
  let a = 0,
    b = 1;
  while (true) {
    yield a;
    [a, b] = [b, a + b];
  }
};

const gen = fibGenerator();
for (let i = 0; i < 5; ++i) {
  console.log(gen.next().value);
}
