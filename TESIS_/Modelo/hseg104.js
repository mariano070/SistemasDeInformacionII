gx.evt.autoSkip=false;function hseg104(){this.ServerClass="HSEG104";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.SetStandaloneVars=function(){this.AV8SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV7USUARIO=gx.fn.getControlValue("vUSUARIO")};this.Validv_Usucod=function(){try{var a=gx.util.balloon.getNew("vUSUCOD");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Validv_Siscod=function(){try{var a=gx.util.balloon.getNew("vSISCOD");
this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Prg_cod=function(){try{if(gx.fn.currentGridRowImpl(17)===0){return true}var a=gx.util.balloon.getNew("PRG_COD",gx.fn.currentGridRowImpl(17));this.AnyError=0;this.StandaloneModal();this.StandaloneNotModal()}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Usu_cod=function(){try{if(gx.fn.currentGridRowImpl(17)===0){return true}var a=gx.util.balloon.getNew("USU_COD",gx.fn.currentGridRowImpl(17));
this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Sis_cod=function(){try{if(gx.fn.currentGridRowImpl(17)===0){return true}var a=gx.util.balloon.getNew("SIS_COD",gx.fn.currentGridRowImpl(17));this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e11522_client=function(){this.executeServerEvent("'ALTA'",false,arguments[0])};this.e13522_client=function(){this.executeServerEvent("'MODIFICA'",false,arguments[0])
};this.e12522_client=function(){this.executeServerEvent("'BAJA'",false,arguments[0])};this.e14522_client=function(){this.executeServerEvent("'AGREGA PROGRAMAS'",false,arguments[0])};this.e17522_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e18522_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[3,7,8,12,13,18,19,20,21,22,23,24,25,28];this.GXLastCtrlId=28;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",17,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"hseg104",[],false,1,true,true,9,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.Grid1Container.addSingleLineEdit(126,18,"PRG_COD","Código","","PRG_COD","int",68,"px",4,4,"right",null,[],126,"PRG_COD",true,0,false,false);this.Grid1Container.addSingleLineEdit(127,19,"PRG_DES","Descripción","","PRG_DES","char",445,"px",30,30,"left",null,[],127,"PRG_DES",true,0,false,false);this.Grid1Container.addComboBox(128,20,"PRG_EXT","Entorno Publicación","PRG_EXT","char",null,0,true,false,0,"px");this.Grid1Container.addSingleLineEdit(117,21,"PRG_WEB","Nombre Objeto Web","","PRG_WEB","char",0,"px",30,30,"left",null,[],117,"PRG_WEB",true,0,false,false);
this.Grid1Container.addSingleLineEdit(6,22,"USU_COD","CODIGO","","USU_COD","char",0,"px",16,16,"left",null,[],6,"USU_COD",false,0,false,false);this.Grid1Container.addSingleLineEdit(7,23,"USU_DES","DESCRIPCION","","USU_DES","char",0,"px",50,50,"left",null,[],7,"USU_DES",false,0,false,false);this.Grid1Container.addSingleLineEdit(116,24,"SIS_COD","CODIGO","","SIS_COD","int",0,"px",3,3,"right",null,[],116,"SIS_COD",false,0,false,false);this.Grid1Container.addSingleLineEdit(259,25,"SIS_DES","DESCRIPCION","","SIS_DES","char",0,"px",15,15,"left",null,[],259,"SIS_DES",false,0,false,false);
this.setGrid(this.Grid1Container);this.GXValidFnc[3]={fld:"TABLE2",grid:0};this.GXValidFnc[6]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[7]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:this.Validv_Usucod,isvalid:null,fld:"vUSUCOD",gxz:"ZV5USUCOD",gxold:"OV5USUCOD",gxvar:"AV5USUCOD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5USUCOD=a},v2z:function(a){gx.O.ZV5USUCOD=a},v2c:function(){gx.fn.setControlValue("vUSUCOD",gx.O.AV5USUCOD,1)},c2v:function(){gx.O.AV5USUCOD=this.val()
},val:function(){return gx.fn.getControlValue("vUSUCOD")},nac:function(){return false}};this.GXValidFnc[8]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSUDES",gxz:"ZV6USUDES",gxold:"OV6USUDES",gxvar:"AV6USUDES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6USUDES=a},v2z:function(a){gx.O.ZV6USUDES=a},v2c:function(){gx.fn.setControlValue("vUSUDES",gx.O.AV6USUDES,1)},c2v:function(){gx.O.AV6USUDES=this.val()},val:function(){return gx.fn.getControlValue("vUSUDES")
},nac:function(){return false}};this.GXValidFnc[11]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[12]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Validv_Siscod,isvalid:null,rgrid:[this.Grid1Container],fld:"vSISCOD",gxz:"ZV9SISCOD",gxold:"OV9SISCOD",gxvar:"AV9SISCOD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9SISCOD=gx.num.intval(a)},v2z:function(a){gx.O.ZV9SISCOD=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vSISCOD",gx.O.AV9SISCOD,1)
},c2v:function(){gx.O.AV9SISCOD=this.val()},val:function(){return gx.fn.getIntegerValue("vSISCOD",".")},nac:function(){return false}};this.GXValidFnc[13]={lvl:0,type:"char",len:15,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vSISDES",gxz:"ZV10SISDES",gxold:"OV10SISDES",gxvar:"AV10SISDES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10SISDES=a},v2z:function(a){gx.O.ZV10SISDES=a},v2c:function(){gx.fn.setControlValue("vSISDES",gx.O.AV10SISDES,1)},c2v:function(){gx.O.AV10SISDES=this.val()
},val:function(){return gx.fn.getControlValue("vSISDES")},nac:function(){return false}};this.GXValidFnc[18]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:17,gxgrid:this.Grid1Container,fnc:this.Valid_Prg_cod,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[19,20,21,23,25],ip:[19,20,21,23,25,18,22,24],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A126PRG_COD=gx.num.intval(a)},v2z:function(a){gx.O.Z126PRG_COD=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRG_COD",gx.fn.currentGridRowImpl(17),gx.O.A126PRG_COD,1)
},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRG_COD",gx.fn.currentGridRowImpl(17),".")},nac:function(){return false}};this.GXValidFnc[19]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:17,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRG_DES",gxz:"Z127PRG_DES",gxold:"O127PRG_DES",gxvar:"A127PRG_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A127PRG_DES=a},v2z:function(a){gx.O.Z127PRG_DES=a},v2c:function(){gx.fn.setGridControlValue("PRG_DES",gx.fn.currentGridRowImpl(17),gx.O.A127PRG_DES,1)
},c2v:function(){gx.O.A127PRG_DES=this.val()},val:function(){return gx.fn.getGridControlValue("PRG_DES",gx.fn.currentGridRowImpl(17))},nac:function(){return false}};this.GXValidFnc[20]={lvl:2,type:"char",len:3,dec:0,sign:false,ro:1,grid:17,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRG_EXT",gxz:"Z128PRG_EXT",gxold:"O128PRG_EXT",gxvar:"A128PRG_EXT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A128PRG_EXT=a},v2z:function(a){gx.O.Z128PRG_EXT=a},v2c:function(){gx.fn.setGridComboBoxValue("PRG_EXT",gx.fn.currentGridRowImpl(17),gx.O.A128PRG_EXT)
},c2v:function(){gx.O.A128PRG_EXT=this.val()},val:function(){return gx.fn.getGridControlValue("PRG_EXT",gx.fn.currentGridRowImpl(17))},nac:function(){return false}};this.GXValidFnc[21]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:17,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRG_WEB",gxz:"Z117PRG_WEB",gxold:"O117PRG_WEB",gxvar:"A117PRG_WEB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A117PRG_WEB=a},v2z:function(a){gx.O.Z117PRG_WEB=a},v2c:function(){gx.fn.setGridControlValue("PRG_WEB",gx.fn.currentGridRowImpl(17),gx.O.A117PRG_WEB,0)
},c2v:function(){gx.O.A117PRG_WEB=this.val()},val:function(){return gx.fn.getGridControlValue("PRG_WEB",gx.fn.currentGridRowImpl(17))},nac:function(){return false}};this.GXValidFnc[22]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:17,gxgrid:this.Grid1Container,fnc:this.Valid_Usu_cod,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A6USU_COD=a},v2z:function(a){gx.O.Z6USU_COD=a},v2c:function(){gx.fn.setGridControlValue("USU_COD",gx.fn.currentGridRowImpl(17),gx.O.A6USU_COD,0)
},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getGridControlValue("USU_COD",gx.fn.currentGridRowImpl(17))},nac:function(){return false}};this.GXValidFnc[23]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:17,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"USU_DES",gxz:"Z7USU_DES",gxold:"O7USU_DES",gxvar:"A7USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A7USU_DES=a},v2z:function(a){gx.O.Z7USU_DES=a},v2c:function(){gx.fn.setGridControlValue("USU_DES",gx.fn.currentGridRowImpl(17),gx.O.A7USU_DES,0)
},c2v:function(){gx.O.A7USU_DES=this.val()},val:function(){return gx.fn.getGridControlValue("USU_DES",gx.fn.currentGridRowImpl(17))},nac:function(){return false}};this.GXValidFnc[24]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:17,gxgrid:this.Grid1Container,fnc:this.Valid_Sis_cod,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A116SIS_COD=gx.num.intval(a)},v2z:function(a){gx.O.Z116SIS_COD=gx.num.intval(a)
},v2c:function(){gx.fn.setGridControlValue("SIS_COD",gx.fn.currentGridRowImpl(17),gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("SIS_COD",gx.fn.currentGridRowImpl(17),".")},nac:function(){return false}};this.GXValidFnc[25]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:1,grid:17,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"SIS_DES",gxz:"Z259SIS_DES",gxold:"O259SIS_DES",gxvar:"A259SIS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A259SIS_DES=a
},v2z:function(a){gx.O.Z259SIS_DES=a},v2c:function(){gx.fn.setGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(17),gx.O.A259SIS_DES,0)},c2v:function(){gx.O.A259SIS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(17))},nac:function(){return false}};this.GXValidFnc[28]={fld:"TABLE1",grid:0};this.AV5USUCOD="";this.ZV5USUCOD="";this.OV5USUCOD="";this.AV6USUDES="";this.ZV6USUDES="";this.OV6USUDES="";this.AV9SISCOD=0;this.ZV9SISCOD=0;this.OV9SISCOD=0;
this.AV10SISDES="";this.ZV10SISDES="";this.OV10SISDES="";this.Z126PRG_COD=0;this.O126PRG_COD=0;this.Z127PRG_DES="";this.O127PRG_DES="";this.Z128PRG_EXT="";this.O128PRG_EXT="";this.Z117PRG_WEB="";this.O117PRG_WEB="";this.Z6USU_COD="";this.O6USU_COD="";this.Z7USU_DES="";this.O7USU_DES="";this.Z116SIS_COD=0;this.O116SIS_COD=0;this.Z259SIS_DES="";this.O259SIS_DES="";this.AV8SISTEMA="";this.AV7USUARIO="";this.A126PRG_COD=0;this.A127PRG_DES="";this.A128PRG_EXT="";this.A117PRG_WEB="";this.A6USU_COD="";this.A7USU_DES="";
this.A116SIS_COD=0;this.A259SIS_DES="";this.ServerEvents=["e11522_client","e13522_client","e12522_client","e14522_client","e17522_client","e18522_client"];this.VarControlMap.AV8SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.AV7USUARIO={id:"vUSUARIO",grid:0,type:"char"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[7]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[12]);this.SetStandaloneVars()}hseg104.prototype=new gx.GxObject;gx.setParentObj(new hseg104());