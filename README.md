分支：

1、 在VS上新建的分支master/dev为本地分支，它们在本地的Repo中；

2、 本地贮存库上的master/dev分支可对应的与GitHub上的master/dev分支进行同步操作；

3、 所有的代码更改在本地dev分支上进行。

每次编写代码前的操作：

1、 在GitHub上，将其他人merge进主master的所有commit，merge到你本人GitHub的master上；

2、 在VS上，切换至本地master分支，将orgin/master分支合并到本地master分支上；

3、 在VS上，切换至本地dev分支，将本地master分支合并到本地dev分支上；

4、 开始编制代码。

每次提交更改的操作：

1、 右键解决方案，点击“提交”，并将本地的dev分支同步推送至GitHub上的dev分支；

2、 在GitHub上的dev分支上进行merge操作，将其merge到GitHub上的master分支，成功后，将GitHub上的dev分支删除（强烈推荐）；

3、 将GitHub上的master分支进行PullRequest操作，将推送申请提交给主master分支。
