/**
 * @param {*} obj
 * @param {*} classFunction
 * @return {boolean}
 */
var checkIfInstanceOf = function (obj, classFunction) {
  if (typeof classFunction !== "function") return false;

  if (obj === null || obj === undefined) return false;

  let currentProto = Object.getPrototypeOf(Object(obj));

  while (currentProto !== null) {
    if (currentProto === classFunction.prototype) {
      return true;
    }
    currentProto = Object.getPrototypeOf(currentProto);
  }

  return false;
};

const dog = () => {
  class Animal {}
  class Dog extends Animal {}
  return checkIfInstanceOf(new Dog(), Animal);
};
console.log(checkIfInstanceOf(new Date(), Date)); // true
console.log(dog()); // true
console.log(checkIfInstanceOf(Date, Date)); // false
console.log(checkIfInstanceOf(5, Number)); // true
console.log(checkIfInstanceOf(5n, Object)); // true
