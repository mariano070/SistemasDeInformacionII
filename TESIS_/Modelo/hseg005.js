gx.evt.autoSkip=false;function hseg005(){this.ServerClass="HSEG005";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.SetStandaloneVars=function(){this.AV5USUCOD=gx.fn.getControlValue("vUSUCOD")};this.Valid_Prg_cod=function(){try{if(gx.fn.currentGridRowImpl(7)===0){return true}var a=gx.util.balloon.getNew("PRG_COD",gx.fn.currentGridRowImpl(7));this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e11562_client=function(){this.executeServerEvent("'FIRST'",false,arguments[0])
};this.e12562_client=function(){this.executeServerEvent("'PREVIOUS'",false,arguments[0])};this.e13562_client=function(){this.executeServerEvent("'NEXT'",false,arguments[0])};this.e14562_client=function(){this.executeServerEvent("'LAST'",false,arguments[0])};this.e16562_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e17562_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[3,8,9,10,11];this.GXLastCtrlId=11;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",7,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"hseg005",[],false,1,true,true,9,false,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.Grid1Container.addSingleLineEdit(116,8,"SIS_COD","Código","","SIS_COD","int",0,"px",3,3,"right",null,[],116,"SIS_COD",true,0,false,false);this.Grid1Container.addSingleLineEdit(259,9,"SIS_DES","Sistema","","SIS_DES","char",0,"px",15,15,"left",null,[],259,"SIS_DES",true,0,false,false);this.Grid1Container.addSingleLineEdit(126,10,"PRG_COD","Código","","PRG_COD","int",0,"px",4,4,"right",null,[],126,"PRG_COD",true,0,false,false);this.Grid1Container.addSingleLineEdit(127,11,"PRG_DES","Programa","","PRG_DES","char",0,"px",30,30,"left",null,[],127,"PRG_DES",true,0,false,false);
this.setGrid(this.Grid1Container);this.GXValidFnc[3]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:7,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A116SIS_COD=gx.num.intval(a)},v2z:function(a){gx.O.Z116SIS_COD=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("SIS_COD",gx.fn.currentGridRowImpl(7),gx.O.A116SIS_COD,1)
},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("SIS_COD",gx.fn.currentGridRowImpl(7),".")},nac:function(){return false}};this.GXValidFnc[9]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:1,grid:7,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"SIS_DES",gxz:"Z259SIS_DES",gxold:"O259SIS_DES",gxvar:"A259SIS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A259SIS_DES=a},v2z:function(a){gx.O.Z259SIS_DES=a},v2c:function(){gx.fn.setGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(7),gx.O.A259SIS_DES,1)
},c2v:function(){gx.O.A259SIS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(7))},nac:function(){return false}};this.GXValidFnc[10]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:7,gxgrid:this.Grid1Container,fnc:this.Valid_Prg_cod,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A126PRG_COD=gx.num.intval(a)},v2z:function(a){gx.O.Z126PRG_COD=gx.num.intval(a)
},v2c:function(){gx.fn.setGridControlValue("PRG_COD",gx.fn.currentGridRowImpl(7),gx.O.A126PRG_COD,1)},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRG_COD",gx.fn.currentGridRowImpl(7),".")},nac:function(){return false}};this.GXValidFnc[11]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:7,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PRG_DES",gxz:"Z127PRG_DES",gxold:"O127PRG_DES",gxvar:"A127PRG_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A127PRG_DES=a
},v2z:function(a){gx.O.Z127PRG_DES=a},v2c:function(){gx.fn.setGridControlValue("PRG_DES",gx.fn.currentGridRowImpl(7),gx.O.A127PRG_DES,1)},c2v:function(){gx.O.A127PRG_DES=this.val()},val:function(){return gx.fn.getGridControlValue("PRG_DES",gx.fn.currentGridRowImpl(7))},nac:function(){return false}};this.Z116SIS_COD=0;this.O116SIS_COD=0;this.Z259SIS_DES="";this.O259SIS_DES="";this.Z126PRG_COD=0;this.O126PRG_COD=0;this.Z127PRG_DES="";this.O127PRG_DES="";this.AV5USUCOD="";this.A116SIS_COD=0;this.A259SIS_DES="";
this.A126PRG_COD=0;this.A127PRG_DES="";this.ServerEvents=["e11562_client","e12562_client","e13562_client","e14562_client","e16562_client","e17562_client"];this.VarControlMap.AV5USUCOD={id:"vUSUCOD",grid:0,type:"char"};this.SetStandaloneVars()}hseg005.prototype=new gx.GxObject;gx.setParentObj(new hseg005());