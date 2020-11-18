read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Given Time and Distance should return fare"
git push origin $a
git checkout master
git merge $a
git push origin master --force
