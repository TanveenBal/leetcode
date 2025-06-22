/**
 * @param {number} n
 * @param {number[][]} entries
 */
var MovieRentingSystem = function (n, entries) {
  this.shops = {}; // shopId => list of [movie, price]
  this.movies = {}; // movieId => list of [shop, price]
  this.rented_movies = {}; // key = "shop,movie" => price
  this.searchCache = {}; // movieId => cached [shop1, shop2, ...]

  for (const [shop, movie, price] of entries) {
    if (!this.shops[shop]) this.shops[shop] = [];
    if (!this.movies[movie]) this.movies[movie] = [];

    this.shops[shop].push([movie, price]);
    this.movies[movie].push([shop, price]);
  }
};

/**
 * @param {number} movie
 * @return {number[]}
 */

MovieRentingSystem.prototype.search = function (movie) {
  if (this.searchCache[movie]) {
    return this.searchCache[movie];
  }

  if (!this.movies[movie]) return [];

  let available = [];

  for (const [shop, price] of this.movies[movie]) {
    const key = `${shop},${movie}`;
    if (!(key in this.rented_movies)) {
      available.push([shop, price]);
    }
  }

  available.sort((a, b) => {
    if (a[1] !== b[1]) return a[1] - b[1]; // price
    return a[0] - b[0]; // shop
  });

  const result = available.slice(0, 5).map(([shop]) => shop);
  this.searchCache[movie] = result;

  return result;
}; /**
 * @param {number} shop
 * @param {number} movie
 * @return {void}
 */
MovieRentingSystem.prototype.rent = function (shop, movie) {
  const key = `${shop},${movie}`;

  for (const [m, price] of this.shops[shop]) {
    if (m === movie) {
      this.rented_movies[key] = price;
      break;
    }
  }
  delete this.searchCache[movie];
};

/**
 * @param {number} shop
 * @param {number} movie
 * @return {void}
 */
MovieRentingSystem.prototype.drop = function (shop, movie) {
  const key = `${shop},${movie}`;
  delete this.rented_movies[key];
  delete this.searchCache[movie];
};

/**
 * @return {number[][]}
 */
MovieRentingSystem.prototype.report = function () {
  const rentedList = [];

  for (const key in this.rented_movies) {
    const [shopStr, movieStr] = key.split(",");
    const shop = parseInt(shopStr, 10);
    const movie = parseInt(movieStr, 10);
    const price = this.rented_movies[key];
    rentedList.push([shop, movie, price]);
  }

  rentedList.sort((a, b) => {
    if (a[2] !== b[2]) return a[2] - b[2]; // price
    if (a[0] !== b[0]) return a[0] - b[0]; // shop
    return a[1] - b[1]; // movie
  });

  let finalRentedList = [];
  let i = 0;
  for (const [shop, movie, _] of rentedList) {
    if (i === 5) break;
    finalRentedList.push([shop, movie]);
    ++i;
  }

  return finalRentedList;
};

/**
 * Your MovieRentingSystem object will be instantiated and called as such:
 * var obj = new MovieRentingSystem(n, entries)
 * var param_1 = obj.search(movie)
 * obj.rent(shop,movie)
 * obj.drop(shop,movie)
 * var param_4 = obj.report()
 */
