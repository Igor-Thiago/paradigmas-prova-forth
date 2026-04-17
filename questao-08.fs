
: sign' ( n -- s )
	dup 0< if
		drop -1 exit
	then
	dup 0> if
		drop 1 exit
	then
	drop 0
;

: sum ( ... n -- soma )
	dup 0= if
		exit
	then
	>r
	0
	r>
	0 do
		+
	loop
;

: has-zero ( ... -- ... flag )
	depth dup 0= if
		drop 0 exit
	then
	0 swap
	0 do
		i 1+ pick 0= if
			drop -1 unloop exit
		then
	loop
;