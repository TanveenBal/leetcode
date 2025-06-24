var Node = function (val, next = null) {
  this.val = val;
  this.next = next;
};

var MyStack = function () {
  this.topNode = null;
};

/**
 * @param {number} x
 * @return {void}
 */
MyStack.prototype.push = function (x) {
  const newNode = new Node(x, this.topNode);
  this.topNode = newNode;
};

/**
 * @return {number}
 */
MyStack.prototype.pop = function () {
  if (!this.topNode) return null;
  const val = this.topNode.val;
  this.topNode = this.topNode.next;
  return val;
};

/**
 * @return {number}
 */
MyStack.prototype.top = function () {
  return this.topNode ? this.topNode.val : null;
};

/**
 * @return {boolean}
 */
MyStack.prototype.empty = function () {
  return this.topNode === null;
};

/**
 * Your MyStack object will be instantiated and called as such:
 * var obj = new MyStack()
 * obj.push(x)
 * var param_2 = obj.pop()
 * var param_3 = obj.top()
 * var param_4 = obj.empty()
 */
