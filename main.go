package main

import (
	"log"
	"net/http"
)

func home(w http.ResponseWriter, r *http.Request) {
	w.Write([]byte("Hello from the home endpoint in the finance manager!"))
}

func main() {
	mux := http.NewServeMux()
	mux.HandleFunc("/", home);
	
	log.Print("Starting server on http://localhost:4001");

	err := http.ListenAndServe(":4001", mux)
	log.Fatal(err)
}