var Node = function (key, value) {
  this.key = key;
  this.value = value;
  this.prev = null;
  this.next = null;
};

var DoublyLinkedList = function () {
  this.head = new Node(null, null);
  this.tail = new Node(null, null);
  this.head.next = this.tail;
  this.tail.prev = this.head;
};

DoublyLinkedList.prototype.pushFront = function (node) {
  node.next = this.head.next;
  node.prev = this.head;
  this.head.next.prev = node;
  this.head.next = node;
};

DoublyLinkedList.prototype.pushBack = function (node) {
  node.prev = this.tail.prev;
  node.next = this.tail;
  this.tail.prev.next = node;
  this.tail.prev = node;
};

DoublyLinkedList.prototype.remove = function (node) {
  node.prev.next = node.next;
  node.next.prev = node.prev;
};

/**
 * @param {number} capacity
 */
var LRUCache = function (capacity) {
  this.list = new DoublyLinkedList();
  this.cache_map = new Map();
  this.curr_capacity = 0;
  this.capacity = capacity;
};

/**
 * @param {number} key
 * @return {number}
 */
LRUCache.prototype.get = function (key) {
  if (this.cache_map.has(key)) {
    this.update(key);
    return this.cache_map.get(key).value;
  } else {
    return -1;
  }
};

/**
 * @param {number} key
 * @param {number} value
 * @return {void}
 */
LRUCache.prototype.put = function (key, value) {
  if (this.cache_map.has(key)) {
    let node = this.cache_map.get(key);
    this.cache_map.set(key, node); // update map
    this.update(key); // update linked list
    node.value = value; // update node
  } else {
    if (this.curr_capacity === this.capacity) {
      let lruNode = this.list.head.next;
      this.cache_map.delete(lruNode.key); // delete from map
      this.list.remove(lruNode); // delete from linked list
      --this.curr_capacity;
    }
    let node = new Node(key, value); // create new node
    this.list.pushBack(node); // add node
    this.cache_map.set(key, node); // add key to map
    ++this.curr_capacity;
  }
};

/**
 * @param {number} key
 * @return {void}
 */
LRUCache.prototype.update = function (key) {
  let node = this.cache_map.get(key);
  this.list.remove(node);
  this.list.pushBack(node);
};
/**
 * Your LRUCache object will be instantiated and called as such:
 * var obj = new LRUCache(capacity)
 * var param_1 = obj.get(key)
 * obj.put(key,value)
 */
