read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Given Multiple rides should return ride fare and average"
git push origin $a
git checkout master
git merge $a
git push origin master --force
