gx.evt.autoSkip=false;function hseg101(){this.ServerClass="HSEG101";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.SetStandaloneVars=function(){this.AV8SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV7USUARIO=gx.fn.getControlValue("vUSUARIO")};this.Valid_Prg_sis=function(){try{if(gx.fn.currentGridRowImpl(22)===0){return true}var a=gx.util.balloon.getNew("PRG_SIS",gx.fn.currentGridRowImpl(22));this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()
}catch(b){}return true};this.e184u2_client=function(){this.clearMessages();this.refreshOutputs([])};this.e174u2_client=function(){this.clearMessages();this.AV18window.Url=gx.http.formatLink("segu06.aspx",[this.AV9SISCOD,this.A126PRG_COD]);this.AV18window.ReturnParms=["AV9SISCOD","A126PRG_COD"];this.AV18window.Width=400;gx.popup.open(this.AV18window);this.refreshOutputs([{ctrl:"vWINDOW",prop:"Width"},{ctrl:"vWINDOW",prop:"Object"}])};this.e114u2_client=function(){this.executeServerEvent("'ALTA'",true,arguments[0])
};this.e144u2_client=function(){this.executeServerEvent("'BAJA'",true,arguments[0])};this.e154u2_client=function(){this.executeServerEvent("'MODIFICA'",true,arguments[0])};this.e124u2_client=function(){this.executeServerEvent("'MENU X'",false,arguments[0])};this.e194u2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e204u2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[3,7,8,11,15,18,23,24,25,26,27,28,29,33];this.GXLastCtrlId=33;
this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",22,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"hseg101",[],false,1,true,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Update","vUPDATE",23,0,"px",17,"px","e154u2_client","","");this.Grid1Container.addBitmap("&Delete","vDELETE",24,0,"px",17,"px","e144u2_client","","");this.Grid1Container.addSingleLineEdit(126,25,"PRG_COD","Código","","PRG_COD","int",96,"px",4,4,"right",null,[],126,"PRG_COD",true,0,false,false);
this.Grid1Container.addSingleLineEdit(127,26,"PRG_DES","Programa","","PRG_DES","char",389,"px",30,30,"left",null,[],127,"PRG_DES",true,0,false,false);this.Grid1Container.addSingleLineEdit(164,27,"PRG_SIS","CODIGO DE SISTEMA","","PRG_SIS","int",0,"px",3,3,"right",null,[],164,"PRG_SIS",false,0,false,false);this.Grid1Container.addSingleLineEdit(259,28,"SIS_DES","DESCRIPCION","","SIS_DES","char",0,"px",15,15,"left",null,[],259,"SIS_DES",false,0,false,false);this.Grid1Container.addComboBox(128,29,"PRG_EXT","Entorno","PRG_EXT","char",null,0,true,false,0,"px");
this.setGrid(this.Grid1Container);this.GXValidFnc[3]={fld:"TABLE2",grid:0};this.GXValidFnc[6]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[7]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vSISCOD",gxz:"ZV9SISCOD",gxold:"OV9SISCOD",gxvar:"AV9SISCOD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9SISCOD=gx.num.intval(a)},v2z:function(a){gx.O.ZV9SISCOD=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vSISCOD",gx.O.AV9SISCOD,1)
},c2v:function(){gx.O.AV9SISCOD=this.val()},val:function(){return gx.fn.getIntegerValue("vSISCOD",".")},nac:function(){return false}};this.GXValidFnc[8]={lvl:0,type:"char",len:15,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vSISDES",gxz:"ZV10SISDES",gxold:"OV10SISDES",gxvar:"AV10SISDES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10SISDES=a},v2z:function(a){gx.O.ZV10SISDES=a},v2c:function(){gx.fn.setControlValue("vSISDES",gx.O.AV10SISDES,1)},c2v:function(){gx.O.AV10SISDES=this.val()
},val:function(){return gx.fn.getControlValue("vSISDES")},nac:function(){return false}};this.GXValidFnc[11]={fld:"TABLE3",grid:0};this.GXValidFnc[14]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[15]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPRGDES",gxz:"ZV6PRGDES",gxold:"OV6PRGDES",gxvar:"AV6PRGDES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6PRGDES=a},v2z:function(a){gx.O.ZV6PRGDES=a},v2c:function(){gx.fn.setControlValue("vPRGDES",gx.O.AV6PRGDES,1)
},c2v:function(){gx.O.AV6PRGDES=this.val()},val:function(){return gx.fn.getControlValue("vPRGDES")},nac:function(){return false}};this.GXValidFnc[18]={fld:"INSERT",grid:0};this.GXValidFnc[23]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV19Update",gxold:"OV19Update",gxvar:"AV19Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV19Update=a},v2z:function(a){gx.O.ZV19Update=a},v2c:function(){},c2v:function(){gx.O.AV19Update=this.val()
},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(22))},nac:function(){return false}};this.GXValidFnc[24]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV20Delete",gxold:"OV20Delete",gxvar:"AV20Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV20Delete=a},v2z:function(a){gx.O.ZV20Delete=a},v2c:function(){},c2v:function(){gx.O.AV20Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(22))
},nac:function(){return false}};this.GXValidFnc[25]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A126PRG_COD=gx.num.intval(a)},v2z:function(a){gx.O.Z126PRG_COD=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRG_COD",gx.fn.currentGridRowImpl(22),gx.O.A126PRG_COD,1)},c2v:function(){gx.O.A126PRG_COD=this.val()
},val:function(){return gx.fn.getGridIntegerValue("PRG_COD",gx.fn.currentGridRowImpl(22),".")},nac:function(){return false}};this.GXValidFnc[26]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRG_DES",gxz:"Z127PRG_DES",gxold:"O127PRG_DES",gxvar:"A127PRG_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A127PRG_DES=a},v2z:function(a){gx.O.Z127PRG_DES=a},v2c:function(){gx.fn.setGridControlValue("PRG_DES",gx.fn.currentGridRowImpl(22),gx.O.A127PRG_DES,1)
},c2v:function(){gx.O.A127PRG_DES=this.val()},val:function(){return gx.fn.getGridControlValue("PRG_DES",gx.fn.currentGridRowImpl(22))},nac:function(){return false}};this.GXValidFnc[27]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:22,gxgrid:this.Grid1Container,fnc:this.Valid_Prg_sis,isvalid:null,rgrid:[],fld:"PRG_SIS",gxz:"Z164PRG_SIS",gxold:"O164PRG_SIS",gxvar:"A164PRG_SIS",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A164PRG_SIS=gx.num.intval(a)},v2z:function(a){gx.O.Z164PRG_SIS=gx.num.intval(a)
},v2c:function(){gx.fn.setGridControlValue("PRG_SIS",gx.fn.currentGridRowImpl(22),gx.O.A164PRG_SIS,0)},c2v:function(){gx.O.A164PRG_SIS=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRG_SIS",gx.fn.currentGridRowImpl(22),".")},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"SIS_DES",gxz:"Z259SIS_DES",gxold:"O259SIS_DES",gxvar:"A259SIS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A259SIS_DES=a
},v2z:function(a){gx.O.Z259SIS_DES=a},v2c:function(){gx.fn.setGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(22),gx.O.A259SIS_DES,0)},c2v:function(){gx.O.A259SIS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(22))},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"char",len:3,dec:0,sign:false,ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRG_EXT",gxz:"Z128PRG_EXT",gxold:"O128PRG_EXT",gxvar:"A128PRG_EXT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A128PRG_EXT=a
},v2z:function(a){gx.O.Z128PRG_EXT=a},v2c:function(){gx.fn.setGridComboBoxValue("PRG_EXT",gx.fn.currentGridRowImpl(22),gx.O.A128PRG_EXT)},c2v:function(){gx.O.A128PRG_EXT=this.val()},val:function(){return gx.fn.getGridControlValue("PRG_EXT",gx.fn.currentGridRowImpl(22))},nac:function(){return false}};this.GXValidFnc[33]={fld:"TABLE4",grid:0};this.AV9SISCOD=0;this.ZV9SISCOD=0;this.OV9SISCOD=0;this.AV10SISDES="";this.ZV10SISDES="";this.OV10SISDES="";this.AV6PRGDES="";this.ZV6PRGDES="";this.OV6PRGDES="";
this.ZV19Update="";this.OV19Update="";this.ZV20Delete="";this.OV20Delete="";this.Z126PRG_COD=0;this.O126PRG_COD=0;this.Z127PRG_DES="";this.O127PRG_DES="";this.Z164PRG_SIS=0;this.O164PRG_SIS=0;this.Z259SIS_DES="";this.O259SIS_DES="";this.Z128PRG_EXT="";this.O128PRG_EXT="";this.AV8SISTEMA="";this.AV7USUARIO="";this.AV19Update="";this.AV20Delete="";this.A126PRG_COD=0;this.A127PRG_DES="";this.A164PRG_SIS=0;this.A259SIS_DES="";this.A128PRG_EXT="";this.AV18window={};this.ServerEvents=["e114u2_client","e144u2_client","e154u2_client","e124u2_client","e194u2_client","e204u2_client"];
this.VarControlMap.AV8SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.AV7USUARIO={id:"vUSUARIO",grid:0,type:"char"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[15]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[7]);this.Grid1Container.addRefreshingVar({rfrVar:"AV20Delete",rfrProp:"Tooltiptext"});this.Grid1Container.addRefreshingVar({rfrVar:"AV20Delete",rfrProp:"Value"});this.Grid1Container.addRefreshingVar({rfrVar:"AV19Update",rfrProp:"Tooltiptext"});this.Grid1Container.addRefreshingVar({rfrVar:"AV19Update",rfrProp:"Value"});
this.SetStandaloneVars()}hseg101.prototype=new gx.GxObject;gx.setParentObj(new hseg101());