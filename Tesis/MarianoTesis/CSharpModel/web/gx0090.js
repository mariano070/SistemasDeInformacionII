gx.evt.autoSkip=false;function gx0090(){this.ServerClass="Gx0090";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV7pTTBUS8_CodUsuario=gx.fn.getControlValue("vPTTBUS8_CODUSUARIO")};this.e132t2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e142t2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,14,17,18,22,23,26];
this.GXLastCtrlId=26;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",21,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0090",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",22,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(40,23,"TTBUS8_CODUSUARIO","Cód. Usuario","","TTBUS8_CodUsuario","char",0,"px",16,16,"left",null,[],40,"TTBUS8_CodUsuario",true,0,false,false);
this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKTTBUS8_CODUSUARIO",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCTTBUS8_CODUSUARIO",gxz:"ZV6cTTBUS8_CodUsuario",gxold:"OV6cTTBUS8_CodUsuario",gxvar:"AV6cTTBUS8_CodUsuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cTTBUS8_CodUsuario=a
},v2z:function(a){gx.O.ZV6cTTBUS8_CodUsuario=a},v2c:function(){gx.fn.setControlValue("vCTTBUS8_CODUSUARIO",gx.O.AV6cTTBUS8_CodUsuario,0)},c2v:function(){gx.O.AV6cTTBUS8_CodUsuario=this.val()},val:function(){return gx.fn.getControlValue("vCTTBUS8_CODUSUARIO")},nac:function(){return false}};this.GXValidFnc[17]={fld:"GROUP2",grid:0};this.GXValidFnc[18]={fld:"TABLE3",grid:0};this.GXValidFnc[22]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:21,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(21))},nac:function(){return false}};this.GXValidFnc[23]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:21,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"TTBUS8_CODUSUARIO",gxz:"Z40TTBUS8_CodUsuario",gxold:"O40TTBUS8_CodUsuario",gxvar:"A40TTBUS8_CodUsuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A40TTBUS8_CodUsuario=a
},v2z:function(a){gx.O.Z40TTBUS8_CodUsuario=a},v2c:function(){gx.fn.setGridControlValue("TTBUS8_CODUSUARIO",gx.fn.currentGridRowImpl(21),gx.O.A40TTBUS8_CodUsuario,0)},c2v:function(){gx.O.A40TTBUS8_CodUsuario=this.val()},val:function(){return gx.fn.getGridControlValue("TTBUS8_CODUSUARIO",gx.fn.currentGridRowImpl(21))},nac:function(){return false}};this.GXValidFnc[26]={fld:"TABLE4",grid:0};this.AV6cTTBUS8_CodUsuario="";this.ZV6cTTBUS8_CodUsuario="";this.OV6cTTBUS8_CodUsuario="";this.ZV5LinkSelection="";
this.OV5LinkSelection="";this.Z40TTBUS8_CodUsuario="";this.O40TTBUS8_CodUsuario="";this.AV7pTTBUS8_CodUsuario="";this.AV5LinkSelection="";this.A40TTBUS8_CodUsuario="";this.ServerEvents=["e132t2_client","e142t2_client"];this.VarControlMap.AV7pTTBUS8_CodUsuario={id:"vPTTBUS8_CODUSUARIO",grid:0,type:"char"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.SetStandaloneVars()}gx0090.prototype=new gx.GxObject;gx.setParentObj(new gx0090());