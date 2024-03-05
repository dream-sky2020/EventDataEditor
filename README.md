我参与了古代人生模拟游戏的开发，该游戏会出现随机的事件，我需要设计一套事件系统和与事件系统匹配的事件数据，千奇百怪的事件只需要通过修改事件数据就可以完成，事件的设计是由主策划担任，我作为紫薇游戏团队的唯一程序，考虑到事件设计者——主策划不具备有编程能力，有可能填写事件数据时无法遵循我事先设计好的数据填写规范，于是，我需要为其提供创建编辑游戏需要的事件数据的编辑器，以便于加快其编写事件数据的速度，该编辑器会跟据使用者的填写生成相应的数据，而不必人来留心遵守规范，规避了人会因为疲劳和粗心大意而错误填写导致的数据报错。

我通过Net开发了相应的应用软件，该软件提供了通过友好的可视化图形，可以通过简单直观的界面创建事件数据，并且可以将编写好的数据存储到本地文件中，或是从本地文件读取数据到应用中修改。

编辑器功能：

从本地打开事件数据列表

保存事件数据列表到本地

事件数据列表添加事件数据

事件数据列表移除事件数据

事件数据列表修改事件数据

编辑事件文本

为事件添加选项数据

为事件移除选项数据

为事件修改选项数据

为选项数据添加前置条件数据

——包括属性和tag要求

还可以为选项添加选择后可能（如果只有一个结果那时一定）发生的结果

结果发生的概率

以及当相应结果发生时

还有对各实体的影响

![alt text](https://github.com/dream-sky2020/EventDataEditor/blob/master/image-20240302181846628.png)https://github.com/dream-sky2020/EventDataEditor/blob/master/image-20240302181846628.png)
