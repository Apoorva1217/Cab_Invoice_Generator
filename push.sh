read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Given Cab Agency support two caregories: Normal and Premium"
git push origin $a
git checkout master
git merge $a
git push origin master --force
