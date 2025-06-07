class EventEmitter {
  /**
   * @param {string} eventName
   * @param {Function} callback
   * @return {Object}
   */
  constructor() {
    this.events = {};
  }
  subscribe(eventName, callback) {
    if (!this.events[eventName]) this.events[eventName] = [];
    const event = callback;
    this.events[eventName].push(event);

    return {
      unsubscribe: () => {
        const index = this.events[eventName].indexOf(event);
        if (index > -1) {
          this.events[eventName].splice(index, 1);
          return undefined;
        }
      },
    };
  }

  /**
   * @param {string} eventName
   * @param {Array} args
   * @return {Array}
   */
  emit(eventName, args = []) {
    const result = [];

    if (this.events[eventName]) {
      for (let i = 0; i < this.events[eventName].length; ++i) {
        result.push(this.events[eventName][i](...args));
      }
      // for (const event in this.events[eventName]) {
      //   result.push(event(...args));
      // }
    }

    return result;
  }
}

/**
 * const emitter = new EventEmitter();
 *
 * // Subscribe to the onClick event with onClickCallback
 * function onClickCallback() { return 99 }
 * const sub = emitter.subscribe('onClick', onClickCallback);
 *
 * emitter.emit('onClick'); // [99]
 * sub.unsubscribe(); // undefined
 * emitter.emit('onClick'); // []
 */
