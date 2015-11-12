/*
               File: AppMasterSD
        Description: Application Master Page
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:33.82
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function appmastersd() {
   this.ServerClass =  "AppMasterSD" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.IsMasterPage=true;
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.e14072_client=function()
   {
      this.executeServerEvent("ENTER_MPAGE", true);
   };
   this.e15072_client=function()
   {
      this.executeServerEvent("CANCEL_MPAGE", true);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,8,11,14,20,23];
   this.GXLastCtrlId =23;
   this.GXValidFnc[2]={fld:"TABLE2",grid:0};
   this.GXValidFnc[5]={fld:"TABLE1",grid:0};
   this.GXValidFnc[8]={fld:"IMAGE1",grid:0};
   this.GXValidFnc[11]={fld:"IMAGE2",grid:0};
   this.GXValidFnc[14]={fld:"TABLE3",grid:0};
   this.GXValidFnc[20]={fld:"TABLE4",grid:0};
   this.GXValidFnc[23]={fld:"TABLE5",grid:0};
   this.ServerEvents = ["e14072_client" ,"e15072_client"];
   this.SetStandaloneVars( );
}
appmastersd.prototype = new gx.GxObject;
gx.setMasterPage(new appmastersd());
