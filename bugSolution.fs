let xRef = ref 10
let yRef = ref 20

let add xRef yRef = !xRef + !yRef

let z = add xRef yRef

printfn "%d" z
xRef := 15
yRef := 25
printfn "%d" (add xRef yRef)