package main

import (
	"fmt"
	"math"
	"math/rand"
)

func main() {
	fmt.Println("Hello, 世界")

	fmt.Println("My favorite number is", rand.Intn(10))

	fmt.Println("My sqrt number is", math.Sqrt(121))
	fmt.Println("My sqrt number is", math.Pi)

	a := 5
	b := 4
	a = 5
	b = 9
	fmt.Println(a, b)

}
