gx.evt.autoSkip=false;function hprc000_(){this.ServerClass="HPRC000_";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.SetStandaloneVars=function(){};this.e16202_client=function(){this.executeServerEvent("'BORRAR'",false,arguments[0])};this.e15202_client=function(){this.executeServerEvent("'EJECUTAR AHORA'",false,arguments[0])};this.e18202_client=function(){this.executeServerEvent("'ALTA PRIORIDAD'",false,arguments[0])};this.e17202_client=function(){this.executeServerEvent("'ESTABLECER HORA DE INICIO'",false,arguments[0])
};this.e11202_client=function(){this.executeServerEvent("'FIRST'",false,arguments[0])};this.e12202_client=function(){this.executeServerEvent("'PREVIOUS'",false,arguments[0])};this.e13202_client=function(){this.executeServerEvent("'NEXT'",false,arguments[0])};this.e14202_client=function(){this.executeServerEvent("'LAST'",false,arguments[0])};this.e22202_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e23202_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])
};this.GXValidFnc=[];this.GXCtrlIds=[3,8,9,15,16,17,18,19,20,21,22,23,27,30,48,49,50,51,52,53,54,55,56,57,60];this.GXLastCtrlId=60;this.Grid_activosContainer=new gx.grid.grid(this,2,"WbpLvl2",14,"Grid_activos","Grid_activos","Grid_activosContainer",this.CmpContext,this.IsMasterPage,"hprc000_",[],false,1,false,true,0,false,false,false,"",0,"px","Nueva fila",false,false,false,null,null,false,"");this.Grid_activosContainer.addSingleLineEdit(79,15,"PRC_NRO","Nº Proceso","","PRC_NRO","int",0,"px",10,10,"right",null,[],79,"PRC_NRO",true,0,false,false);
this.Grid_activosContainer.addSingleLineEdit(94,16,"PRC_USR","Usuario","","PRC_USR","char",0,"px",16,16,"left",null,[],94,"PRC_USR",true,0,false,false);this.Grid_activosContainer.addSingleLineEdit(92,17,"PRC_ING","Ingreso","","PRC_ING","dtime",0,"px",14,8,"right",null,[],92,"PRC_ING",true,5,false,false);this.Grid_activosContainer.addSingleLineEdit(95,18,"PRC_DES","Descripción","","PRC_DES","char",0,"px",50,50,"left",null,[],95,"PRC_DES",true,0,false,false);this.Grid_activosContainer.addSingleLineEdit(158,19,"PRC_EST","Estado","","PRC_EST","int",0,"px",1,1,"right",null,[],158,"PRC_EST",true,0,false,false);
this.Grid_activosContainer.addSingleLineEdit(96,20,"PRC_INI","Inicio Proc.","","PRC_INI","dtime",0,"px",14,8,"right",null,[],96,"PRC_INI",true,5,false,false);this.Grid_activosContainer.addSingleLineEdit(157,21,"PRC_FIN","Ult. Novedad","","PRC_FIN","dtime",0,"px",14,8,"right",null,[],157,"PRC_FIN",true,5,false,false);this.Grid_activosContainer.addSingleLineEdit(161,22,"PRC_MSG","Mensaje","","PRC_MSG","char",0,"px",75,75,"left",null,[],161,"PRC_MSG",true,0,false,false);this.Grid_activosContainer.addSingleLineEdit(97,23,"PRC_EML","HORA ENVIO MAIL SOPORTE","","PRC_EML","dtime",0,"px",14,8,"right",null,[],97,"PRC_EML",false,5,false,false);
this.setGrid(this.Grid_activosContainer);this.Grid_usuarioContainer=new gx.grid.grid(this,3,"WbpLvl3",47,"Grid_usuario","Grid_usuario","Grid_usuarioContainer",this.CmpContext,this.IsMasterPage,"hprc000_",[],false,1,false,true,10,false,false,false,"",0,"px","Nueva fila",true,false,true,null,null,false,"");this.Grid_usuarioContainer.addCheckBox("Eliminar",48,"vELIMINAR","Elim.","","ELIMINAR","char","*"," ",null,true,false,0,"px");this.Grid_usuarioContainer.addSingleLineEdit(79,49,"PRC_NRO","Número","","PRC_NRO","int",0,"px",10,10,"right",null,[],79,"PRC_NRO",true,0,false,false);
this.Grid_usuarioContainer.addSingleLineEdit(92,50,"PRC_ING","Ingreso Proceso","","PRC_ING","dtime",0,"px",14,8,"right",null,[],92,"PRC_ING",true,5,false,false);this.Grid_usuarioContainer.addSingleLineEdit(95,51,"PRC_DES","Descripción","","PRC_DES","char",0,"px",50,50,"left",null,[],95,"PRC_DES",true,0,false,false);this.Grid_usuarioContainer.addComboBox(158,52,"PRC_EST","Estado","PRC_EST","int",null,0,true,false,0,"px");this.Grid_usuarioContainer.addSingleLineEdit(96,53,"PRC_INI","Inicio Proceso","","PRC_INI","dtime",0,"px",14,8,"right",null,[],96,"PRC_INI",true,5,false,false);
this.Grid_usuarioContainer.addSingleLineEdit("Prc_sal",54,"vPRC_SAL","Resultado","","PRC_SAL","char",0,"px",100,100,"left",null,[],"Prc_sal","PRC_SAL",true,0,false,false);this.Grid_usuarioContainer.addSingleLineEdit(157,55,"PRC_FIN","Ultima Novedad","","PRC_FIN","dtime",0,"px",14,8,"right",null,[],157,"PRC_FIN",true,5,false,false);this.Grid_usuarioContainer.addSingleLineEdit(161,56,"PRC_MSG","Mensaje","","PRC_MSG","char",0,"px",75,75,"left",null,[],161,"PRC_MSG",true,0,false,false);this.Grid_usuarioContainer.addSingleLineEdit(94,57,"PRC_USR","Usuario","","PRC_USR","char",0,"px",16,16,"left",null,[],94,"PRC_USR",true,0,false,false);
this.setGrid(this.Grid_usuarioContainer);this.GXValidFnc[3]={fld:"TABLE1",grid:0};this.GXValidFnc[6]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[8]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vAHORA",gxz:"ZV5AHORA",gxold:"OV5AHORA",gxvar:"AV5AHORA",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5AHORA=gx.fn.toDatetimeValue(a)},v2z:function(a){gx.O.ZV5AHORA=gx.fn.toDatetimeValue(a)
},v2c:function(){gx.fn.setControlValue("vAHORA",gx.O.AV5AHORA,0)},c2v:function(){gx.O.AV5AHORA=this.val()},val:function(){return gx.fn.getControlValue("vAHORA")},nac:function(){return false}};this.GXValidFnc[9]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vTEXTO_PROCESOS",gxz:"ZV12TEXTO_PROCESOS",gxold:"OV12TEXTO_PROCESOS",gxvar:"AV12TEXTO_PROCESOS",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV12TEXTO_PROCESOS=a},v2z:function(a){gx.O.ZV12TEXTO_PROCESOS=a
},v2c:function(){gx.fn.setControlValue("vTEXTO_PROCESOS",gx.O.AV12TEXTO_PROCESOS,0)},c2v:function(){gx.O.AV12TEXTO_PROCESOS=this.val()},val:function(){return gx.fn.getControlValue("vTEXTO_PROCESOS")},nac:function(){return false}};this.GXValidFnc[15]={lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,grid:14,gxgrid:this.Grid_activosContainer,fnc:null,isvalid:null,rgrid:[],fld:"PRC_NRO",gxz:"Z79PRC_NRO",gxold:"O79PRC_NRO",gxvar:"A79PRC_NRO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A79PRC_NRO=gx.num.intval(a)
},v2z:function(a){gx.O.Z79PRC_NRO=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRC_NRO",gx.fn.currentGridRowImpl(14),gx.O.A79PRC_NRO,0)},c2v:function(){gx.O.A79PRC_NRO=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRC_NRO",gx.fn.currentGridRowImpl(14),".")},nac:function(){return false}};this.GXValidFnc[16]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:14,gxgrid:this.Grid_activosContainer,fnc:null,isvalid:null,fld:"PRC_USR",gxz:"Z94PRC_USR",gxold:"O94PRC_USR",gxvar:"A94PRC_USR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A94PRC_USR=a
},v2z:function(a){gx.O.Z94PRC_USR=a},v2c:function(){gx.fn.setGridControlValue("PRC_USR",gx.fn.currentGridRowImpl(14),gx.O.A94PRC_USR,0)},c2v:function(){gx.O.A94PRC_USR=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_USR",gx.fn.currentGridRowImpl(14))},nac:function(){return false}};this.GXValidFnc[17]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:14,gxgrid:this.Grid_activosContainer,fnc:null,isvalid:null,fld:"PRC_ING",gxz:"Z92PRC_ING",gxold:"O92PRC_ING",gxvar:"A92PRC_ING",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A92PRC_ING=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z92PRC_ING=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PRC_ING",gx.fn.currentGridRowImpl(14),gx.O.A92PRC_ING,0)},c2v:function(){gx.O.A92PRC_ING=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_ING",gx.fn.currentGridRowImpl(14))},nac:function(){return false}};this.GXValidFnc[18]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:14,gxgrid:this.Grid_activosContainer,fnc:null,isvalid:null,fld:"PRC_DES",gxz:"Z95PRC_DES",gxold:"O95PRC_DES",gxvar:"A95PRC_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A95PRC_DES=a
},v2z:function(a){gx.O.Z95PRC_DES=a},v2c:function(){gx.fn.setGridControlValue("PRC_DES",gx.fn.currentGridRowImpl(14),gx.O.A95PRC_DES,0)},c2v:function(){gx.O.A95PRC_DES=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_DES",gx.fn.currentGridRowImpl(14))},nac:function(){return false}};this.GXValidFnc[19]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:14,gxgrid:this.Grid_activosContainer,fnc:null,isvalid:null,rgrid:[],fld:"PRC_EST",gxz:"Z158PRC_EST",gxold:"O158PRC_EST",gxvar:"A158PRC_EST",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A158PRC_EST=gx.num.intval(a)
},v2z:function(a){gx.O.Z158PRC_EST=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRC_EST",gx.fn.currentGridRowImpl(14),gx.O.A158PRC_EST,0)},c2v:function(){gx.O.A158PRC_EST=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRC_EST",gx.fn.currentGridRowImpl(14),".")},nac:function(){return false}};this.GXValidFnc[20]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:14,gxgrid:this.Grid_activosContainer,fnc:null,isvalid:null,fld:"PRC_INI",gxz:"Z96PRC_INI",gxold:"O96PRC_INI",gxvar:"A96PRC_INI",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A96PRC_INI=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z96PRC_INI=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PRC_INI",gx.fn.currentGridRowImpl(14),gx.O.A96PRC_INI,0)},c2v:function(){gx.O.A96PRC_INI=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_INI",gx.fn.currentGridRowImpl(14))},nac:function(){return false}};this.GXValidFnc[21]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:14,gxgrid:this.Grid_activosContainer,fnc:null,isvalid:null,fld:"PRC_FIN",gxz:"Z157PRC_FIN",gxold:"O157PRC_FIN",gxvar:"A157PRC_FIN",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A157PRC_FIN=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z157PRC_FIN=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PRC_FIN",gx.fn.currentGridRowImpl(14),gx.O.A157PRC_FIN,0)},c2v:function(){gx.O.A157PRC_FIN=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_FIN",gx.fn.currentGridRowImpl(14))},nac:function(){return false}};this.GXValidFnc[22]={lvl:2,type:"char",len:75,dec:0,sign:false,ro:1,grid:14,gxgrid:this.Grid_activosContainer,fnc:null,isvalid:null,fld:"PRC_MSG",gxz:"Z161PRC_MSG",gxold:"O161PRC_MSG",gxvar:"A161PRC_MSG",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A161PRC_MSG=a
},v2z:function(a){gx.O.Z161PRC_MSG=a},v2c:function(){gx.fn.setGridControlValue("PRC_MSG",gx.fn.currentGridRowImpl(14),gx.O.A161PRC_MSG,0)},c2v:function(){gx.O.A161PRC_MSG=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_MSG",gx.fn.currentGridRowImpl(14))},nac:function(){return false}};this.GXValidFnc[23]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:14,gxgrid:this.Grid_activosContainer,fnc:null,isvalid:null,fld:"PRC_EML",gxz:"Z97PRC_EML",gxold:"O97PRC_EML",gxvar:"A97PRC_EML",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A97PRC_EML=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z97PRC_EML=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PRC_EML",gx.fn.currentGridRowImpl(14),gx.O.A97PRC_EML,0)},c2v:function(){gx.O.A97PRC_EML=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_EML",gx.fn.currentGridRowImpl(14))},nac:function(){return false}};this.GXValidFnc[26]={fld:"TEXTBLOCK3",format:0,grid:0};this.GXValidFnc[27]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSUARIO",gxz:"ZV13USUARIO",gxold:"OV13USUARIO",gxvar:"AV13USUARIO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV13USUARIO=a
},v2z:function(a){gx.O.ZV13USUARIO=a},v2c:function(){gx.fn.setControlValue("vUSUARIO",gx.O.AV13USUARIO,0)},c2v:function(){gx.O.AV13USUARIO=this.val()},val:function(){return gx.fn.getControlValue("vUSUARIO")},nac:function(){return false}};this.GXValidFnc[30]={fld:"TABLE3",grid:0};this.GXValidFnc[48]={lvl:3,type:"char",len:1,dec:0,sign:false,ro:0,grid:47,gxgrid:this.Grid_usuarioContainer,fnc:null,isvalid:null,fld:"vELIMINAR",gxz:"ZV7ELIMINAR",gxold:"OV7ELIMINAR",gxvar:"AV7ELIMINAR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV7ELIMINAR=a
},v2z:function(a){gx.O.ZV7ELIMINAR=a},v2c:function(){gx.fn.setGridCheckBoxValue("vELIMINAR",gx.fn.currentGridRowImpl(47),gx.O.AV7ELIMINAR,"*")},c2v:function(){gx.O.AV7ELIMINAR=this.val()},val:function(){return gx.fn.getGridCheckBoxValue("vELIMINAR",gx.fn.currentGridRowImpl(47),"*"," ")},nac:function(){return false}};this.GXValidFnc[49]={lvl:3,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,grid:47,gxgrid:this.Grid_usuarioContainer,fnc:null,isvalid:null,rgrid:[],fld:"PRC_NRO",gxz:"Z79PRC_NRO",gxold:"O79PRC_NRO",gxvar:"A79PRC_NRO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A79PRC_NRO=gx.num.intval(a)
},v2z:function(a){gx.O.Z79PRC_NRO=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRC_NRO",gx.fn.currentGridRowImpl(47),gx.O.A79PRC_NRO,0)},c2v:function(){gx.O.A79PRC_NRO=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRC_NRO",gx.fn.currentGridRowImpl(47),".")},nac:function(){return false}};this.GXValidFnc[50]={lvl:3,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:47,gxgrid:this.Grid_usuarioContainer,fnc:null,isvalid:null,fld:"PRC_ING",gxz:"Z92PRC_ING",gxold:"O92PRC_ING",gxvar:"A92PRC_ING",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A92PRC_ING=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z92PRC_ING=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PRC_ING",gx.fn.currentGridRowImpl(47),gx.O.A92PRC_ING,0)},c2v:function(){gx.O.A92PRC_ING=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_ING",gx.fn.currentGridRowImpl(47))},nac:function(){return false}};this.GXValidFnc[51]={lvl:3,type:"char",len:50,dec:0,sign:false,ro:1,grid:47,gxgrid:this.Grid_usuarioContainer,fnc:null,isvalid:null,fld:"PRC_DES",gxz:"Z95PRC_DES",gxold:"O95PRC_DES",gxvar:"A95PRC_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A95PRC_DES=a
},v2z:function(a){gx.O.Z95PRC_DES=a},v2c:function(){gx.fn.setGridControlValue("PRC_DES",gx.fn.currentGridRowImpl(47),gx.O.A95PRC_DES,0)},c2v:function(){gx.O.A95PRC_DES=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_DES",gx.fn.currentGridRowImpl(47))},nac:function(){return false}};this.GXValidFnc[52]={lvl:3,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:47,gxgrid:this.Grid_usuarioContainer,fnc:null,isvalid:null,rgrid:[],fld:"PRC_EST",gxz:"Z158PRC_EST",gxold:"O158PRC_EST",gxvar:"A158PRC_EST",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A158PRC_EST=gx.num.intval(a)
},v2z:function(a){gx.O.Z158PRC_EST=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRC_EST",gx.fn.currentGridRowImpl(47),gx.O.A158PRC_EST,0)},c2v:function(){gx.O.A158PRC_EST=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRC_EST",gx.fn.currentGridRowImpl(47),".")},nac:function(){return false}};this.GXValidFnc[53]={lvl:3,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:47,gxgrid:this.Grid_usuarioContainer,fnc:null,isvalid:null,fld:"PRC_INI",gxz:"Z96PRC_INI",gxold:"O96PRC_INI",gxvar:"A96PRC_INI",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A96PRC_INI=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z96PRC_INI=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PRC_INI",gx.fn.currentGridRowImpl(47),gx.O.A96PRC_INI,0)},c2v:function(){gx.O.A96PRC_INI=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_INI",gx.fn.currentGridRowImpl(47))},nac:function(){return false}};this.GXValidFnc[54]={lvl:3,type:"char",len:100,dec:0,sign:false,ro:0,grid:47,gxgrid:this.Grid_usuarioContainer,fnc:null,isvalid:null,fld:"vPRC_SAL",gxz:"ZV9PRC_SAL",gxold:"OV9PRC_SAL",gxvar:"AV9PRC_SAL",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9PRC_SAL=a
},v2z:function(a){gx.O.ZV9PRC_SAL=a},v2c:function(){gx.fn.setGridControlValue("vPRC_SAL",gx.fn.currentGridRowImpl(47),gx.O.AV9PRC_SAL,0)},c2v:function(){gx.O.AV9PRC_SAL=this.val()},val:function(){return gx.fn.getGridControlValue("vPRC_SAL",gx.fn.currentGridRowImpl(47))},nac:function(){return false}};this.GXValidFnc[55]={lvl:3,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:47,gxgrid:this.Grid_usuarioContainer,fnc:null,isvalid:null,fld:"PRC_FIN",gxz:"Z157PRC_FIN",gxold:"O157PRC_FIN",gxvar:"A157PRC_FIN",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A157PRC_FIN=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z157PRC_FIN=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PRC_FIN",gx.fn.currentGridRowImpl(47),gx.O.A157PRC_FIN,0)},c2v:function(){gx.O.A157PRC_FIN=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_FIN",gx.fn.currentGridRowImpl(47))},nac:function(){return false}};this.GXValidFnc[56]={lvl:3,type:"char",len:75,dec:0,sign:false,ro:1,grid:47,gxgrid:this.Grid_usuarioContainer,fnc:null,isvalid:null,fld:"PRC_MSG",gxz:"Z161PRC_MSG",gxold:"O161PRC_MSG",gxvar:"A161PRC_MSG",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A161PRC_MSG=a
},v2z:function(a){gx.O.Z161PRC_MSG=a},v2c:function(){gx.fn.setGridControlValue("PRC_MSG",gx.fn.currentGridRowImpl(47),gx.O.A161PRC_MSG,0)},c2v:function(){gx.O.A161PRC_MSG=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_MSG",gx.fn.currentGridRowImpl(47))},nac:function(){return false}};this.GXValidFnc[57]={lvl:3,type:"char",len:16,dec:0,sign:false,ro:1,grid:47,gxgrid:this.Grid_usuarioContainer,fnc:null,isvalid:null,fld:"PRC_USR",gxz:"Z94PRC_USR",gxold:"O94PRC_USR",gxvar:"A94PRC_USR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A94PRC_USR=a
},v2z:function(a){gx.O.Z94PRC_USR=a},v2c:function(){gx.fn.setGridControlValue("PRC_USR",gx.fn.currentGridRowImpl(47),gx.O.A94PRC_USR,0)},c2v:function(){gx.O.A94PRC_USR=this.val()},val:function(){return gx.fn.getGridControlValue("PRC_USR",gx.fn.currentGridRowImpl(47))},nac:function(){return false}};this.GXValidFnc[60]={fld:"TABLE2",grid:0};this.AV5AHORA=gx.date.nullDate();this.ZV5AHORA=gx.date.nullDate();this.OV5AHORA=gx.date.nullDate();this.AV12TEXTO_PROCESOS="";this.ZV12TEXTO_PROCESOS="";this.OV12TEXTO_PROCESOS="";
this.Z79PRC_NRO=0;this.O79PRC_NRO=0;this.Z94PRC_USR="";this.O94PRC_USR="";this.Z92PRC_ING=gx.date.nullDate();this.O92PRC_ING=gx.date.nullDate();this.Z95PRC_DES="";this.O95PRC_DES="";this.Z158PRC_EST=0;this.O158PRC_EST=0;this.Z96PRC_INI=gx.date.nullDate();this.O96PRC_INI=gx.date.nullDate();this.Z157PRC_FIN=gx.date.nullDate();this.O157PRC_FIN=gx.date.nullDate();this.Z161PRC_MSG="";this.O161PRC_MSG="";this.Z97PRC_EML=gx.date.nullDate();this.O97PRC_EML=gx.date.nullDate();this.AV13USUARIO="";this.ZV13USUARIO="";
this.OV13USUARIO="";this.ZV7ELIMINAR="";this.OV7ELIMINAR="";this.ZV9PRC_SAL="";this.OV9PRC_SAL="";this.A160PRC_INV="";this.A159PRC_SAL="";this.A93PRC_NOM="";this.A79PRC_NRO=0;this.A94PRC_USR="";this.A92PRC_ING=gx.date.nullDate();this.A95PRC_DES="";this.A158PRC_EST=0;this.A96PRC_INI=gx.date.nullDate();this.A157PRC_FIN=gx.date.nullDate();this.A161PRC_MSG="";this.A97PRC_EML=gx.date.nullDate();this.AV7ELIMINAR="";this.AV9PRC_SAL="";this.ServerEvents=["e16202_client","e15202_client","e18202_client","e17202_client","e11202_client","e12202_client","e13202_client","e14202_client","e22202_client","e23202_client"];
this.VarControlMap.A159PRC_SAL={id:"PRC_SAL",grid:0,type:"char"};this.Grid_activosContainer.addRefreshingVar({rfrVar:"A159PRC_SAL"});this.Grid_usuarioContainer.addRefreshingVar(this.GXValidFnc[27]);this.Grid_usuarioContainer.addRefreshingVar({rfrVar:"A159PRC_SAL"});this.Grid_usuarioContainer.addRefreshingVar({rfrVar:"A97PRC_EML",rfrProp:"Value"});this.SetStandaloneVars()}hprc000_.prototype=new gx.GxObject;gx.setParentObj(new hprc000_());