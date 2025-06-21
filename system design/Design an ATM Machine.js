var ATM = function () {
  this.cash = new Map();
  this.notes = [20, 50, 100, 200, 500];
  for (const note of this.notes) {
    this.cash.set(note, 0);
  }
};

/**
 * @param {number[]} banknotesCount
 * @return {void}
 */
ATM.prototype.deposit = function (banknotesCount) {
  for (let i = 0; i < banknotesCount.length; ++i) {
    this.cash.set(
      this.notes[i],
      this.cash.get(this.notes[i]) + banknotesCount[i],
    );
  }
};

/**
 * @param {number} amount
 * @return {number[]}
 */
ATM.prototype.withdraw = function (amount) {
  let withdrawn = [0, 0, 0, 0, 0];
  for (let i = this.notes.length - 1; i >= 0; --i) {
    let denom = this.notes[i];
    let available = this.cash.get(denom);

    let use = Math.min(Math.floor(amount / denom), available);
    withdrawn[i] = use;
    amount -= use * denom;
  }

  if (amount === 0) {
    for (let i = 0; i < this.notes.length; ++i) {
      this.cash.set(this.notes[i], this.cash.get(this.notes[i]) - withdrawn[i]);
    }
    return withdrawn;
  }

  return [-1];
};

/**
 * Your ATM object will be instantiated and called as such:
 * var obj = new ATM()
 * obj.deposit(banknotesCount)
 * var param_2 = obj.withdraw(amount)
 */
