intersect :: [Int] -> [Int] -> [Int]
intersect l1 l2 = [x|x<-l1, elem x l2]

-- intersection :: [Int] -> [Int] -> [Int]
-- intersection listOne listTwo = [ n | n <- removeDuplicates (quickSort listOne),
				-- m <- removeDuplicates (quickSort listTwo), n == m]

-- removeDuplicates :: [Int] -> [Int]
-- removeDuplicates list
	-- | length list == 1 = list
	-- | head list == head (tail list) = removeDuplicates (tail list)
	-- | otherwise = head list : removeDuplicates (tail list)

-- quickSort :: [Int] -> [Int]
-- quickSort [] = []
-- quickSort (x:xs) = 
	-- quickSort [y | y <- xs, y <= x] ++ [x] ++ quickSort [z | z <- xs, z > x]	
	
--Encode
-- encode :: [Char] -> [(Char, Int)]
-- endoce [] = []
-- encode (x:xs) = encodeHelper xs x 1
	-- where 
		-- encodeHelper [] ch n = [(ch, n)]
		-- encodeHelper (x:xs) ch n
			-- | ch == x	= encodeHelper xs ch (n + 1)
			-- | otherwise = (ch, n) : (encodeHelper xs x 1)
			
-- --Decode
-- decode :: [(Char, Int)] -> [Char]
-- decode [] = []
-- decode ((ch, n):xs) = (take n (repeat ch)) ++ (decode xs)	

--Rotate
-- myRotate :: Int -> [Int] -> [Int]
-- myRotate 0 list = list
-- myRotate rolls list = myRotate (rolls - 1) ((tail list) ++ [head list]) 


-- myRotate :: [a] -> Int -> [a]
-- myRotate list n = (drop (n `mod` length list) list) 
					-- ++ (take (n `mod` length list) list)


-- permutations :: [Int] -> [[Int]]
-- permutations [] = [[]]
-- permutations list = [ element : restPermutations | element <- list, 
						-- restPermutations <- permutations (delete element list)]
						
-- delete :: Int -> [Int] -> [Int]
-- delete element list 
	-- | length list == 0 = []
	-- | element == head list = delete element (tail list)
	-- | otherwise = head list : delete element (tail list)
						
-- dotProduct :: [Double] -> [Double] -> Double
-- dotProduct vectorOne vectorTwo = sum [ x * y | x <- vectorOne, y <- vectorTwo] 

-- generateTriangles :: Int -> [(Int, Int, Int)]
-- generateTriangles n = [(a, b, c) | a <- [1..n], b <- [1..n], c <- [1..n], 
						-- a + b > c, a + c > b, b + c > a, a + b + c <= n]

-- toInt :: Char -> Int
-- toInt char = fromEnum char

-- toChar :: Int -> Char
-- toChar asciiCode = toEnum asciiCode

-- isLowerLetter :: Char -> Bool	 
-- isLowerLetter char
	-- | char >= 'a' && char <= 'z' = True
	-- | otherwise = False

-- toUpperExpression :: [Char] -> [Char]
-- toUpperExpression string = [ if isLowerLetter char then toChar (toInt char - 32) else char 
															-- | char <- string]

-- findAllDivisors :: [Int] -> [[Int]]
-- findAllDivisors list = [ findDivisor number 1 | number <- list]

-- findDivisor :: Int -> Int -> [Int]
-- findDivisor number counter
	-- | counter > number = []
	-- | number `mod` counter == 0 = counter : findDivisor number (counter + 1)
	-- | otherwise = findDivisor number (counter + 1)
	
-- doubleAll :: [Int] -> [Int]
-- doubleAll list = [ number * 2 | number <- list]



-- myTake :: Int -> [a] -> [a]
-- myTake 0 _ = []
-- myTake n [] = []
-- myTake n (x:xs) 
	-- | n > 0 = x : myTake (n - 1) xs
	-- | otherwise = error "myTake can't accept a negative number."
	
-- myZip :: [a] -> [b] -> [(a,b)]
-- myZip (x:xs) (y:ys) = (x,y) : myZip xs ys
-- myZip (x:xs) [] = []
-- myZip [] (y:ys) = []

-- mySort :: [Int] -> [Int]
-- mySort [] = []
-- mySort (x:xs) = myInsert x (mySort xs)

-- myInsert :: Int -> [Int] -> [Int]
-- myInsert x [] = [x] 
-- myInsert x (y:ys)
	-- | x <= y = x:(y:ys)
	-- | otherwise = y : (myInsert x ys)

-- extractEvens :: [Int] -> [Int]
-- extractEvens [] = []
-- extractEvens (x:xs) 
	-- | x `mod` 2 == 0	= x : extractEvens (xs)
	-- | otherwise 		= extractEvens (xs)

-- doubleAll :: [Int] -> [Int]
-- doubleAll [] 	 = []
-- doubleAll (x:xs) = x * 2 : doubleAll (xs)

-- contains :: [Int] -> Int -> Bool
-- contains [] y 	  = False
-- contains (x:xs) y = (x == y) || contains (xs) y

-- myConcat :: [[a]] -> [a]
-- myConcat [] = []
-- myConcat (x:xs) = x ++ myConcat(xs)

-- addPair :: [Int] -> [Int] -> [Int]
-- addPair listOne listTwo =
	-- [(m + n)| (m, n) <- zip listOne listTwo]

-- addPairWise :: [Int] -> [Int] -> [Int]
-- addPairWise listOne listTwo =
	-- front ++ rear
	-- where 
		-- minLength = min (length listOne) (length listTwo)
		-- front = addPair frontOne frontTwo
		-- rear = rearOne ++ rearTwo
		-- (frontOne, rearOne) = splitAt minLength listOne
		-- (frontTwo, rearTwo) = splitAt minLength listTwo
	
-- factorial :: Integer -> Integer
-- factorial n = factorialHelper n 1 1

-- factorialHelper :: Integer -> Integer -> Integer -> Integer
-- factorialHelper n product counter
	-- | counter > n 	= product
	-- | otherwise 	= factorialHelper n (product * counter) (counter + 1)

-- minAndMax :: Int -> Int -> Int -> (Int, Int, Int)
-- minAndMax a b c
	-- | a >= b && b >= c 		= (a, b, c)
	-- | a >= c && c >= b		= (a, c, b)
	-- | b >= a && a >= c		= (b, a, c)
	-- | b >= c && c >= a		= (b, c, a)
	-- | c >= a && a >= b		= (c, a, b)
	-- | c >= b && b >= a		= (c, b, a)

-- sumOfDigits :: Int -> Int
-- sumOfDigits n
	-- | n == 0 	= 0
	-- | otherwise = (n `mod` 10) + sumOfDigits (n / 10)

-- removeDuplicates :: [Char] -> [Char]
-- removeDuplicates list
	-- | length list == 1					= list
	-- | head list == head (tail list) 	= removeDuplicates (tail list)
	-- | otherwise 						= head list : removeDuplicates (tail list)

-- findMax :: [Int] -> Int
-- findMax list
	-- | length list == 1 = head list
	-- | otherwise 	   = max (head list) (findMax (tail list))

-- findMin :: [Int] -> Int
-- findMin list
	-- | length list == 1 = head list 
	-- | otherwise 	   = min (head list) (findMin (tail list))

-- minAndMax :: [Int] -> (Int, Int)
-- minAndMax list = (findMin list, findMax list)

-- reverseList :: [Int] -> [Int]
-- reverseList list 
	-- | length list == 0 = list
	-- | otherwise 	   = last list : reverseList (init list) 

-- deleteFirstOccurance :: [Int] -> Int -> [Int]
-- deleteFirstOccurance list target 
	-- | head list == target  	  = tail list
	-- | length list == 1 		  = list
	-- | otherwise 		  	  = head list : (deleteFirstOccurance (tail list) target)
	
	
-- repeatMine :: Char -> Int -> String
-- repeatMine ch n 
	-- | n == 0 	= ""
	-- | otherwise = ch : (repeatMine ch (n - 1))

-- isPrime :: Int -> Bool
-- isPrime 1 = False
-- isPrime 2 = True
-- isPrime n = isPrimeHelper 2
	-- where isPrimeHelper i
		-- | (n `mod` i) == 0 		= False
		-- | fromIntegral i > s	= True
		-- | otherwise 			= isPrimeHelper (i + 1)
		-- where
			-- s = (sqrt (fromIntegral n))

-- addPairwise :: [Int] -> [Int] -> [Int]
-- addPairwise listOne listTwo =
	-- [m + n | (m,n) <- zip listOne listTwo]
	
-- addPairwiseTwo :: [Int] -> [Int] -> [Int]
-- addPairwiseTwo listOne listTwo =
	-- front ++ rear
	-- where
	-- minLength = min (length listOne) (length listTwo)
	-- front = addPairwise (take minLength listOne) (take minLength listTwo)
	-- rear = (drop minLength listOne) ++ (drop minLength listTwo)

-- sumSquares :: Int -> Int -> Int
-- sumSquares a b = 
	-- squareA + squareB
	-- where
	-- squareA = a * a
	-- squareB = b * b

-- (&&&) :: Int -> Int -> Int
-- x &&& y
	-- | x >= y 	= x
	-- | otherwise	= y

-- isLower :: Char -> Bool
-- isLower ch 
	-- | ch >= 'a' && ch <= 'z' 	= True
	-- | otherwise					= False

-- isUpper :: Char -> Bool
-- isUpper ch 
	-- | ch >= 'A' && ch <= 'Z'	= True
	-- | otherwise 				= False

-- countLower :: String -> Int
-- countLower str
	-- | length str == 0 			= 0
	-- | isLower (head (str)) 		= 1 + countLower (tail (str))
	-- | otherwise 				= countLower (tail (str))
	
-- countUpper :: String -> Int
-- countUpper str
	-- | length str == 0 			= 0 
	-- | isUpper (head (str))		= 1 + countUpper (tail (str))
	-- | otherwise 				= countUpper (tail (str))

-- lettersCount :: String -> (Int, Int)
-- lettersCount str = (countLower (str), countUpper (str))

-- isPrefix :: String -> String -> Bool
-- isPrefix str substring 
	-- | length substring > length str 	= False
	-- | substring == ""					= True
	-- | head substring /= head str		= False
	-- | otherwise							= isPrefix (tail str) (tail substring)

-- substringCount :: String -> String -> Int
-- substringCount str substring 
	-- | length substring > length str		= 0
	-- | isPrefix str substring 			= 1 + substringCount (tail str) substring
	-- | otherwise 						= substringCount (tail str) substring
	
-- repeatChar :: Char -> Int -> String
-- repeatChar ch n  
	-- | n == 0 	= ""
	-- | otherwise = ch : (repeatChar ch (n - 1))

-- isPrime :: Int -> Bool
-- isPrime 1 = False
-- isPrime n = isPrimeHelper 2
	-- where
		-- isPrimeHelper i
			-- | (n `mod` i == 0) && not(n == 2) = False
			-- | fromIntegral i > s || (n == 2) = True
			-- | otherwise		= isPrimeHelper (i + 1)
			-- where
				-- s = (sqrt (fromIntegral n))

-- fib :: Int -> Int
-- fib n 
	-- | n == 0	= 1
	-- | n == 1	= 1
	-- | otherwise = fib(n - 1) + fib(n - 2)

-- fact :: Int -> Int
-- fact n = 
	-- if n == 1 then 1 else n * fact (n - 1)

-- discriminant :: Float -> Float -> Float -> Float
-- discriminant a b c = b * b - (4 * a * c)

-- numberOfRoots :: Float -> Float -> Float -> Int
-- numberOfRoots a b c
	-- | discriminant a b c < 0 		    = 0
	-- | a == 0 || discriminant a b c == 0 = 1
	-- | discriminant a b c > 0  		    = 2

-- digits :: String -> String
-- digits str = [ch | ch <- str, isDigit ch]

-- addPairs :: [(Int,Int)] -> [Int]
-- addPairs pairList = [m + n | (m,n) <- pairList, m < n]

-- minAndMax :: Int -> Int -> (Int,Int)
-- minAndMax x y 
	-- | x >= y = (y,x)
	-- | otherwise = (x,y)

-- type ShopItem = (String, Int)
-- i1 :: ShopItem
-- i2 :: ShopItem
-- i1 = ("Salt: ", 139)
-- i2 = ("Sugar: ", 200)

-- fact :: Int -> Int
-- fact n =
	-- if n == 1 then 1 else n * fact (n - 1)

-- max :: Int -> Int -> Int
-- max a b =
	-- if a >= b then a else b

-- maxThree :: Int -> Int -> Int -> Int
-- maxThree a b c
	-- | a >= b && a >= c 	= a
	-- | b >= a && b >= c  = b
	-- | otherwise			= c

-- max :: Int -> Int -> Int
-- max numberOne numberTwo 
	-- | numberOne >= numberTwo = numberOne
	-- | otherwise = numberTwo

-- isDigit :: Char -> Bool
-- isDigit character = 
	-- (character >= '0' && character <= '9')