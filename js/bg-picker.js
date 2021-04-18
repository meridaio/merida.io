/* bg-picker
 * Picks one of 4 backgrounds for the site based on the current time of year in the northern hemisphere
 */
(() => {
  document.documentElement.style.setProperty('--background-image', "url('images/" + (() => {
    const month = new Date().getMonth()
    if (month == 11 || month < 2) return "winter-bw.jpg"
    if (month < 5) return "spring-bw.jpg"
    if (month < 8) return "summer-bw.jpg"
    return "fall-bw.jpg"
  })() + "')")
})()