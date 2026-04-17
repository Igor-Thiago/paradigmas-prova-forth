: get ( addr i j -- a )
    swap
    2 *
    +
    cells
    +
    @
;

: M@ ( addr -- )
    dup 0 0 get .
    dup 0 1 get . cr
    dup 1 0 get .
    1 1 get .
;