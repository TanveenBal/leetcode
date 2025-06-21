/**
 * @param {number[]} balance
 */
var Bank = function (balance) {
  this.balances = balance;
};

/**
 * @param {number} account1
 * @param {number} account2
 * @param {number} money
 * @return {boolean}
 */
Bank.prototype.transfer = function (account1, account2, money) {
  if (this.withdraw(account1, money)) {
    if (this.deposit(account2, money)) {
      return true;
    } else {
      this.deposit(account1, money);
    }
  }
  return false;
};

/**
 * @param {number} account
 * @param {number} money
 * @return {boolean}
 */
Bank.prototype.deposit = function (account, money) {
  if (this.valid_account(account)) {
    this.balances[account - 1] += money;
    return true;
  }
  return false;
};

/**
 * @param {number} account
 * @param {number} money
 * @return {boolean}
 */
Bank.prototype.withdraw = function (account, money) {
  if (this.valid_transaction(account, money)) {
    this.balances[account - 1] -= money;
    return true;
  }
  return false;
};

/**
 * @param {number} account
 * @return {boolean}
 */
Bank.prototype.valid_account = function (account) {
  return account > 0 && account <= this.balances.length;
};

/**
 * @param {number} account
 * @param {number} money
 * @return {boolean}
 */
Bank.prototype.valid_transaction = function (account, money) {
  return this.valid_account(account) && money <= this.balances[account - 1];
};

/**
 * Your Bank object will be instantiated and called as such:
 * var obj = new Bank(balance)
 * var param_1 = obj.transfer(account1,account2,money)
 * var param_2 = obj.deposit(account,money)
 * var param_3 = obj.withdraw(account,money)
 */
