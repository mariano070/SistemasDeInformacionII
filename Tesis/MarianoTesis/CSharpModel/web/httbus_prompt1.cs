/*
               File: HTTBUS_prompt1
        Description: Seleccionar Posición
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:0.13
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class httbus_prompt1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public httbus_prompt1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public httbus_prompt1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pTTBUS7_Pos ,
                           out String aP1_pTTBUS7_Des ,
                           out String aP2_pTTBUS7_CodResp ,
                           out String aP3_pTTBUS7_DesResp ,
                           String aP4_USUARIO ,
                           String aP5_Modo )
      {
         this.AV21pTTBUS7_Pos = 0 ;
         this.AV22pTTBUS7_Des = "" ;
         this.AV18pTTBUS7_CodResp = "" ;
         this.AV23pTTBUS7_DesResp = "" ;
         this.AV10USUARIO = aP4_USUARIO;
         this.AV35Modo = aP5_Modo;
         executePrivate();
         aP0_pTTBUS7_Pos=this.AV21pTTBUS7_Pos;
         aP1_pTTBUS7_Des=this.AV22pTTBUS7_Des;
         aP2_pTTBUS7_CodResp=this.AV18pTTBUS7_CodResp;
         aP3_pTTBUS7_DesResp=this.AV23pTTBUS7_DesResp;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            gxfirstwebparm_bkp = gxfirstwebparm ;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( ) ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_30_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_30_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_30_idx, sGXsfl_30_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavGttbus7_codresp_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus7_codresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus7_codresp_Enabled), 5, 0)));
               Grid1_PageSize30 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               A51TTBUS7_RespAux = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
               A39TTBUS7_CodUsuario = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
               A36TTBUS7_DesResp = GetNextPar( ) ;
               n36TTBUS7_DesResp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               A35TTBUS7_CodResp = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A34TTBUS7_Des = GetNextPar( ) ;
               n34TTBUS7_Des = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               AV10USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUARIO", AV10USUARIO);
               A40TTBUS8_CodUsuario = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
               AV35Modo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35Modo", AV35Modo);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize30, A51TTBUS7_RespAux, A39TTBUS7_CodUsuario, A36TTBUS7_DesResp, A35TTBUS7_CodResp, A34TTBUS7_Des, A33TTBUS7_Pos, AV10USUARIO, A40TTBUS8_CodUsuario, AV35Modo) ;
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp ;
            }
            if ( ! entryPointCalled )
            {
               AV21pTTBUS7_Pos = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21pTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21pTTBUS7_Pos), 3, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV22pTTBUS7_Des = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22pTTBUS7_Des", AV22pTTBUS7_Des);
                  AV18pTTBUS7_CodResp = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18pTTBUS7_CodResp", AV18pTTBUS7_CodResp);
                  AV23pTTBUS7_DesResp = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23pTTBUS7_DesResp", AV23pTTBUS7_DesResp);
                  AV10USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUARIO", AV10USUARIO);
                  AV35Modo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35Modo", AV35Modo);
               }
            }
         }
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA082( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START082( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("httbus_prompt1.aspx") + "?" + UrlEncode("" +AV21pTTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim(AV22pTTBUS7_Des)) + "," + UrlEncode(StringUtil.RTrim(AV18pTTBUS7_CodResp)) + "," + UrlEncode(StringUtil.RTrim(AV23pTTBUS7_DesResp)) + "," + UrlEncode(StringUtil.RTrim(AV10USUARIO)) + "," + UrlEncode(StringUtil.RTrim(AV35Modo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vTTBUS7_DESRESP", StringUtil.RTrim( AV25TTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, "vTTBUS7_DES", StringUtil.RTrim( AV20TTBUS7_Des));
         GxWebStd.gx_hidden_field( context, "vPTTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21pTTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS7_DES", StringUtil.RTrim( AV22pTTBUS7_Des));
         GxWebStd.gx_hidden_field( context, "vPTTBUS7_CODRESP", StringUtil.RTrim( AV18pTTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, "vPTTBUS7_DESRESP", StringUtil.RTrim( AV23pTTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV10USUARIO));
         GxWebStd.gx_hidden_field( context, "vMODO", StringUtil.RTrim( AV35Modo));
         GxWebStd.gx_hidden_field( context, "TTBUS7_RESPAUX", StringUtil.LTrim( StringUtil.NToC( (decimal)(A51TTBUS7_RespAux), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS7_CODUSUARIO", StringUtil.RTrim( A39TTBUS7_CodUsuario));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DESRESP", StringUtil.RTrim( A36TTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_CODRESP", StringUtil.RTrim( A35TTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DES", StringUtil.RTrim( A34TTBUS7_Des));
         GxWebStd.gx_hidden_field( context, "TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS8_CODUSUARIO", StringUtil.RTrim( A40TTBUS8_CodUsuario));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE082( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT082( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "HTTBUS_prompt1" ;
      }

      public override String GetPgmdesc( )
      {
         return "Seleccionar Posición" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("httbus_prompt1.aspx") + "?" + UrlEncode("" +AV21pTTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim(AV22pTTBUS7_Des)) + "," + UrlEncode(StringUtil.RTrim(AV18pTTBUS7_CodResp)) + "," + UrlEncode(StringUtil.RTrim(AV23pTTBUS7_DesResp)) + "," + UrlEncode(StringUtil.RTrim(AV10USUARIO)) + "," + UrlEncode(StringUtil.RTrim(AV35Modo)) ;
      }

      protected void WB080( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_082( true) ;
         }
         else
         {
            wb_table1_2_082( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_082e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START082( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Seleccionar Posición", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP080( ) ;
      }

      protected void WS082( )
      {
         START082( ) ;
         EVT082( ) ;
      }

      protected void EVT082( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  /* Check if conditions changed and reset current page numbers */
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_30_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_30_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_30_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_30_idx ;
                              edtavGttbus7_pos_Internalname = "vGTTBUS7_POS_"+sGXsfl_30_idx ;
                              edtavGttbus7_des_Internalname = "vGTTBUS7_DES_"+sGXsfl_30_idx ;
                              edtavGttbus7_codresp_Internalname = "vGTTBUS7_CODRESP_"+sGXsfl_30_idx ;
                              edtavGttbus7_desresp_Internalname = "vGTTBUS7_DESRESP_"+sGXsfl_30_idx ;
                              AV8LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV8LinkSelection));
                              AV29gTTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( edtavGttbus7_pos_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29gTTBUS7_Pos), 3, 0)));
                              AV30gTTBUS7_Des = cgiGet( edtavGttbus7_des_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS7_Des", AV30gTTBUS7_Des);
                              AV31gTTBUS7_CodResp = StringUtil.Upper( cgiGet( edtavGttbus7_codresp_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS7_CodResp", AV31gTTBUS7_CodResp);
                              AV32gTTBUS7_DesResp = StringUtil.Upper( cgiGet( edtavGttbus7_desresp_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS7_DesResp", AV32gTTBUS7_DesResp);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11082 */
                                    E11082 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E12082 */
                                          E12082 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE082( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA082( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavFttbus7_des_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_30_idx ,
                                       String sGXsfl_30_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_30_idx ;
         edtavGttbus7_pos_Internalname = "vGTTBUS7_POS_"+sGXsfl_30_idx ;
         edtavGttbus7_des_Internalname = "vGTTBUS7_DES_"+sGXsfl_30_idx ;
         edtavGttbus7_codresp_Internalname = "vGTTBUS7_CODRESP_"+sGXsfl_30_idx ;
         edtavGttbus7_desresp_Internalname = "vGTTBUS7_DESRESP_"+sGXsfl_30_idx ;
         while ( nGXsfl_30_idx <= nRC_Grid1 )
         {
            sendrow_302( ) ;
            nGXsfl_30_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_30_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_30_idx+1)) ;
            sGXsfl_30_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_30_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_30_idx ;
            edtavGttbus7_pos_Internalname = "vGTTBUS7_POS_"+sGXsfl_30_idx ;
            edtavGttbus7_des_Internalname = "vGTTBUS7_DES_"+sGXsfl_30_idx ;
            edtavGttbus7_codresp_Internalname = "vGTTBUS7_CODRESP_"+sGXsfl_30_idx ;
            edtavGttbus7_desresp_Internalname = "vGTTBUS7_DESRESP_"+sGXsfl_30_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize30 ,
                                        short A51TTBUS7_RespAux ,
                                        String A39TTBUS7_CodUsuario ,
                                        String A36TTBUS7_DesResp ,
                                        String A35TTBUS7_CodResp ,
                                        String A34TTBUS7_Des ,
                                        short A33TTBUS7_Pos ,
                                        String AV10USUARIO ,
                                        String A40TTBUS8_CodUsuario ,
                                        String AV35Modo )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize30) ;
         RF082( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF082( ) ;
         /* End function Refresh */
      }

      protected void RF082( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 30 ;
         nGXsfl_30_idx = 1 ;
         sGXsfl_30_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_30_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_30_idx ;
         edtavGttbus7_pos_Internalname = "vGTTBUS7_POS_"+sGXsfl_30_idx ;
         edtavGttbus7_des_Internalname = "vGTTBUS7_DES_"+sGXsfl_30_idx ;
         edtavGttbus7_codresp_Internalname = "vGTTBUS7_CODRESP_"+sGXsfl_30_idx ;
         edtavGttbus7_desresp_Internalname = "vGTTBUS7_DESRESP_"+sGXsfl_30_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_30_idx ;
            edtavGttbus7_pos_Internalname = "vGTTBUS7_POS_"+sGXsfl_30_idx ;
            edtavGttbus7_des_Internalname = "vGTTBUS7_DES_"+sGXsfl_30_idx ;
            edtavGttbus7_codresp_Internalname = "vGTTBUS7_CODRESP_"+sGXsfl_30_idx ;
            edtavGttbus7_desresp_Internalname = "vGTTBUS7_DESRESP_"+sGXsfl_30_idx ;
            /* Execute user event: E11082 */
            E11082 ();
            wbEnd = 30 ;
            WB080( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         if ( GRID1_nEOF == 0 )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         subGrid1_Islastpage = 1 ;
         return 3 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid1_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP080( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavGttbus7_codresp_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus7_codresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus7_codresp_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV26fTTBUS7_Des = cgiGet( edtavFttbus7_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26fTTBUS7_Des", AV26fTTBUS7_Des);
            AV19fTTBUS7_DesResp = StringUtil.Upper( cgiGet( edtavFttbus7_desresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19fTTBUS7_DesResp", AV19fTTBUS7_DesResp);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV25TTBUS7_DesResp = cgiGet( "vTTBUS7_DESRESP") ;
            AV20TTBUS7_Des = cgiGet( "vTTBUS7_DES") ;
            AV21pTTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( "vPTTBUS7_POS"), ",", ".")) ;
            AV22pTTBUS7_Des = cgiGet( "vPTTBUS7_DES") ;
            AV18pTTBUS7_CodResp = cgiGet( "vPTTBUS7_CODRESP") ;
            AV23pTTBUS7_DesResp = cgiGet( "vPTTBUS7_DESRESP") ;
            AV10USUARIO = cgiGet( "vUSUARIO") ;
            AV35Modo = cgiGet( "vMODO") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      private void E11082( )
      {
         /* Grid1_Load Routine */
         AV8LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV8LinkSelection));
         AV33band = 0 ;
         if ( StringUtil.StrCmp(AV35Modo, "INS") == 0 )
         {
            /* Using cursor H00082 */
            pr_default.execute(0, new Object[] {AV10USUARIO});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A40TTBUS8_CodUsuario = H00082_A40TTBUS8_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
               AV33band = 1 ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            if ( ( ( AV33band == 1 ) ) || ( ( StringUtil.StrCmp(AV10USUARIO, "SUPERVISOR") == 0 ) ) )
            {
               /* Using cursor H00083 */
               pr_default.execute(1);
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A34TTBUS7_Des = H00083_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H00083_n34TTBUS7_Des[0] ;
                  A35TTBUS7_CodResp = H00083_A35TTBUS7_CodResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
                  A36TTBUS7_DesResp = H00083_A36TTBUS7_DesResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
                  n36TTBUS7_DesResp = H00083_n36TTBUS7_DesResp[0] ;
                  A33TTBUS7_Pos = H00083_A33TTBUS7_Pos[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A36TTBUS7_DesResp = H00083_A36TTBUS7_DesResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
                  n36TTBUS7_DesResp = H00083_n36TTBUS7_DesResp[0] ;
                  A34TTBUS7_Des = H00083_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H00083_n34TTBUS7_Des[0] ;
                  AV29gTTBUS7_Pos = A33TTBUS7_Pos ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29gTTBUS7_Pos), 3, 0)));
                  AV30gTTBUS7_Des = A34TTBUS7_Des ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS7_Des", AV30gTTBUS7_Des);
                  AV31gTTBUS7_CodResp = A35TTBUS7_CodResp ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS7_CodResp", AV31gTTBUS7_CodResp);
                  AV32gTTBUS7_DesResp = A36TTBUS7_DesResp ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS7_DesResp", AV32gTTBUS7_DesResp);
                  /* Load Method */
                  if ( wbStart != -1 )
                  {
                     wbStart = 30 ;
                  }
                  if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
                  {
                     sendrow_302( ) ;
                     GRID1_nEOF = 1 ;
                     if ( ( subGrid1_Islastpage == 1 ) && ( ((int)(GRID1_nCurrentRecord) % (subGrid1_Recordsperpage( ))) == 0 ) )
                     {
                        GRID1_nFirstRecordOnPage = GRID1_nCurrentRecord ;
                     }
                  }
                  if ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) )
                  {
                     GRID1_nEOF = 0 ;
                  }
                  GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
                  pr_default.readNext(1);
               }
               pr_default.close(1);
            }
            else
            {
               /* Using cursor H00084 */
               pr_default.execute(2);
               while ( (pr_default.getStatus(2) != 101) )
               {
                  A34TTBUS7_Des = H00084_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H00084_n34TTBUS7_Des[0] ;
                  A35TTBUS7_CodResp = H00084_A35TTBUS7_CodResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
                  A36TTBUS7_DesResp = H00084_A36TTBUS7_DesResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
                  n36TTBUS7_DesResp = H00084_n36TTBUS7_DesResp[0] ;
                  A33TTBUS7_Pos = H00084_A33TTBUS7_Pos[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A36TTBUS7_DesResp = H00084_A36TTBUS7_DesResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
                  n36TTBUS7_DesResp = H00084_n36TTBUS7_DesResp[0] ;
                  A34TTBUS7_Des = H00084_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H00084_n34TTBUS7_Des[0] ;
                  AV34vTTBUS7_Pos = A33TTBUS7_Pos ;
                  if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV10USUARIO) == 0 )
                  {
                     AV29gTTBUS7_Pos = A33TTBUS7_Pos ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29gTTBUS7_Pos), 3, 0)));
                     AV30gTTBUS7_Des = A34TTBUS7_Des ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS7_Des", AV30gTTBUS7_Des);
                     AV31gTTBUS7_CodResp = A35TTBUS7_CodResp ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS7_CodResp", AV31gTTBUS7_CodResp);
                     AV32gTTBUS7_DesResp = A36TTBUS7_DesResp ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS7_DesResp", AV32gTTBUS7_DesResp);
                     /* Load Method */
                     if ( wbStart != -1 )
                     {
                        wbStart = 30 ;
                     }
                     if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
                     {
                        sendrow_302( ) ;
                        GRID1_nEOF = 1 ;
                        if ( ( subGrid1_Islastpage == 1 ) && ( ((int)(GRID1_nCurrentRecord) % (subGrid1_Recordsperpage( ))) == 0 ) )
                        {
                           GRID1_nFirstRecordOnPage = GRID1_nCurrentRecord ;
                        }
                     }
                     if ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) )
                     {
                        GRID1_nEOF = 0 ;
                     }
                     GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
                  }
                  else
                  {
                     /* Using cursor H00085 */
                     pr_default.execute(3, new Object[] {AV34vTTBUS7_Pos, AV10USUARIO});
                     while ( (pr_default.getStatus(3) != 101) )
                     {
                        A39TTBUS7_CodUsuario = H00085_A39TTBUS7_CodUsuario[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
                        A33TTBUS7_Pos = H00085_A33TTBUS7_Pos[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                        A51TTBUS7_RespAux = H00085_A51TTBUS7_RespAux[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
                        if ( A51TTBUS7_RespAux == 1 )
                        {
                           AV29gTTBUS7_Pos = A33TTBUS7_Pos ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29gTTBUS7_Pos), 3, 0)));
                           AV30gTTBUS7_Des = A34TTBUS7_Des ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS7_Des", AV30gTTBUS7_Des);
                           AV31gTTBUS7_CodResp = A35TTBUS7_CodResp ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS7_CodResp", AV31gTTBUS7_CodResp);
                           AV32gTTBUS7_DesResp = A36TTBUS7_DesResp ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS7_DesResp", AV32gTTBUS7_DesResp);
                           /* Load Method */
                           if ( wbStart != -1 )
                           {
                              wbStart = 30 ;
                           }
                           if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
                           {
                              sendrow_302( ) ;
                              GRID1_nEOF = 1 ;
                              if ( ( subGrid1_Islastpage == 1 ) && ( ((int)(GRID1_nCurrentRecord) % (subGrid1_Recordsperpage( ))) == 0 ) )
                              {
                                 GRID1_nFirstRecordOnPage = GRID1_nCurrentRecord ;
                              }
                           }
                           if ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) )
                           {
                              GRID1_nEOF = 0 ;
                           }
                           GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
                        }
                        /* Exiting from a For First loop. */
                        if (true) break;
                     }
                     pr_default.close(3);
                  }
                  pr_default.readNext(2);
               }
               pr_default.close(2);
            }
         }
         else
         {
            /* Using cursor H00086 */
            pr_default.execute(4);
            while ( (pr_default.getStatus(4) != 101) )
            {
               A34TTBUS7_Des = H00086_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H00086_n34TTBUS7_Des[0] ;
               A35TTBUS7_CodResp = H00086_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A36TTBUS7_DesResp = H00086_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H00086_n36TTBUS7_DesResp[0] ;
               A33TTBUS7_Pos = H00086_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A36TTBUS7_DesResp = H00086_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H00086_n36TTBUS7_DesResp[0] ;
               A34TTBUS7_Des = H00086_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H00086_n34TTBUS7_Des[0] ;
               AV29gTTBUS7_Pos = A33TTBUS7_Pos ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29gTTBUS7_Pos), 3, 0)));
               AV30gTTBUS7_Des = A34TTBUS7_Des ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS7_Des", AV30gTTBUS7_Des);
               AV31gTTBUS7_CodResp = A35TTBUS7_CodResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS7_CodResp", AV31gTTBUS7_CodResp);
               AV32gTTBUS7_DesResp = A36TTBUS7_DesResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS7_DesResp", AV32gTTBUS7_DesResp);
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 30 ;
               }
               if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
               {
                  sendrow_302( ) ;
                  GRID1_nEOF = 1 ;
                  if ( ( subGrid1_Islastpage == 1 ) && ( ((int)(GRID1_nCurrentRecord) % (subGrid1_Recordsperpage( ))) == 0 ) )
                  {
                     GRID1_nFirstRecordOnPage = GRID1_nCurrentRecord ;
                  }
               }
               if ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) )
               {
                  GRID1_nEOF = 0 ;
               }
               GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
               pr_default.readNext(4);
            }
            pr_default.close(4);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E12082 */
         E12082 ();
         if (returnInSub) return;
      }

      protected void E12082( )
      {
         /* Enter Routine */
         AV21pTTBUS7_Pos = AV29gTTBUS7_Pos ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21pTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21pTTBUS7_Pos), 3, 0)));
         AV22pTTBUS7_Des = AV30gTTBUS7_Des ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22pTTBUS7_Des", AV22pTTBUS7_Des);
         AV18pTTBUS7_CodResp = AV31gTTBUS7_CodResp ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18pTTBUS7_CodResp", AV18pTTBUS7_CodResp);
         AV23pTTBUS7_DesResp = AV32gTTBUS7_DesResp ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23pTTBUS7_DesResp", AV23pTTBUS7_DesResp);
         context.setWebReturnParms(new Object[] {(short)AV21pTTBUS7_Pos,(String)AV22pTTBUS7_Des,(String)AV18pTTBUS7_CodResp,(String)AV23pTTBUS7_DesResp});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_082( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(439), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(737), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" >") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filtros"+"</legend>") ;
            wb_table2_9_082( true) ;
         }
         else
         {
            wb_table2_9_082( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_082e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_27_082( true) ;
         }
         else
         {
            wb_table3_27_082( false) ;
         }
         return  ;
      }

      protected void wb_table3_27_082e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_082e( true) ;
         }
         else
         {
            wb_table1_2_082e( false) ;
         }
      }

      protected void wb_table3_27_082( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(216), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(721), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "COD. POSICIÓN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "POSICIÓN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "g TTBUS7_ Cod Resp") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "RESPONSABLE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV8LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29gTTBUS7_Pos), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV30gTTBUS7_Des));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV31gTTBUS7_CodResp));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus7_codresp_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV32gTTBUS7_DesResp));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 30 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_30_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_38_082( true) ;
         }
         else
         {
            wb_table4_38_082( false) ;
         }
         return  ;
      }

      protected void wb_table4_38_082e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_082e( true) ;
         }
         else
         {
            wb_table3_27_082e( false) ;
         }
      }

      protected void wb_table4_38_082( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(30), 3, 0)+","+"null"+");", "", "HLP_HTTBUS_prompt1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_38_082e( true) ;
         }
         else
         {
            wb_table4_38_082e( false) ;
         }
      }

      protected void wb_table2_9_082( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockubi_des_Internalname, 1, 1, 0, "POSICIÓN:", "", "", "", 0, lblTextblockubi_des_Jsonclick, "", StyleString, ClassString, "HLP_HTTBUS_prompt1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_30_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus7_des_Internalname, StringUtil.RTrim( AV26fTTBUS7_Des), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV26fTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", 0, edtavFttbus7_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTTBUS_prompt1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockubi_tip2_Internalname, 1, 1, 0, "RESPONSABLE:", "", "", "", 0, lblTextblockubi_tip2_Jsonclick, "", StyleString, ClassString, "HLP_HTTBUS_prompt1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_30_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus7_desresp_Internalname, StringUtil.RTrim( AV19fTTBUS7_DesResp), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV19fTTBUS7_DesResp, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(19);\"", 0, edtavFttbus7_desresp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTTBUS_prompt1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttButton1_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 7, bttButton1_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13082_client"+"'", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(30), 3, 0)+","+"null"+");", "", "HLP_HTTBUS_prompt1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_082e( true) ;
         }
         else
         {
            wb_table2_9_082e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV21pTTBUS7_Pos = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21pTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21pTTBUS7_Pos), 3, 0)));
         AV22pTTBUS7_Des = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22pTTBUS7_Des", AV22pTTBUS7_Des);
         AV18pTTBUS7_CodResp = (String)getParm(obj,2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18pTTBUS7_CodResp", AV18pTTBUS7_CodResp);
         AV23pTTBUS7_DesResp = (String)getParm(obj,3) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23pTTBUS7_DesResp", AV23pTTBUS7_DesResp);
         AV10USUARIO = (String)getParm(obj,4) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUARIO", AV10USUARIO);
         AV35Modo = (String)getParm(obj,5) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35Modo", AV35Modo);
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA082( ) ;
         WS082( ) ;
         WE082( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1929058");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("httbus_prompt1.js", "?1929058");
         /* End function include_jscripts */
      }

      protected void sendrow_302( )
      {
         WB080( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_30_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_30_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0xE5E5E5) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd" ;
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29gTTBUS7_Pos), 3, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV30gTTBUS7_Des))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV31gTTBUS7_CodResp))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( AV32gTTBUS7_DesResp))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV8LinkSelection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus7_pos_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29gTTBUS7_Pos), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV29gTTBUS7_Pos), "ZZ9"),(String)"",(short)0,(String)edtavGttbus7_pos_Jsonclick,(String)"",(short)30,(short)1,(short)-1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus7_des_Internalname,StringUtil.RTrim( AV30gTTBUS7_Des),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV30gTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtavGttbus7_des_Jsonclick,(String)"",(short)30,(short)1,(short)-1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus7_codresp_Internalname,StringUtil.RTrim( AV31gTTBUS7_CodResp),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)0,(int)edtavGttbus7_codresp_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV31gTTBUS7_CodResp, "@!")),(String)"",(short)0,(String)edtavGttbus7_codresp_Jsonclick,(String)"",(short)30,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus7_desresp_Internalname,StringUtil.RTrim( AV32gTTBUS7_DesResp),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV32gTTBUS7_DesResp, "@!")),(String)"",(short)0,(String)edtavGttbus7_desresp_Jsonclick,(String)"",(short)30,(short)1,(short)-1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_30_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_30_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_30_idx+1)) ;
            sGXsfl_30_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_30_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_30_idx ;
            edtavGttbus7_pos_Internalname = "vGTTBUS7_POS_"+sGXsfl_30_idx ;
            edtavGttbus7_des_Internalname = "vGTTBUS7_DES_"+sGXsfl_30_idx ;
            edtavGttbus7_codresp_Internalname = "vGTTBUS7_CODRESP_"+sGXsfl_30_idx ;
            edtavGttbus7_desresp_Internalname = "vGTTBUS7_DESRESP_"+sGXsfl_30_idx ;
         }
         /* End function sendrow_302 */
      }

      protected void init_default_properties( )
      {
         lblTextblockubi_des_Internalname = "TEXTBLOCKUBI_DES" ;
         edtavFttbus7_des_Internalname = "vFTTBUS7_DES" ;
         lblTextblockubi_tip2_Internalname = "TEXTBLOCKUBI_TIP2" ;
         edtavFttbus7_desresp_Internalname = "vFTTBUS7_DESRESP" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavGttbus7_desresp_Jsonclick = "" ;
         edtavGttbus7_codresp_Jsonclick = "" ;
         edtavGttbus7_des_Jsonclick = "" ;
         edtavGttbus7_pos_Jsonclick = "" ;
         edtavFttbus7_desresp_Jsonclick = "" ;
         edtavFttbus7_des_Jsonclick = "" ;
         edtavGttbus7_codresp_Enabled = 0 ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Seleccionar Posición" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         wcpOAV10USUARIO = "" ;
         wcpOAV35Modo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         edtavGttbus7_codresp_Internalname = "" ;
         A39TTBUS7_CodUsuario = "" ;
         A36TTBUS7_DesResp = "" ;
         A35TTBUS7_CodResp = "" ;
         A34TTBUS7_Des = "" ;
         A40TTBUS8_CodUsuario = "" ;
         AV22pTTBUS7_Des = "" ;
         AV18pTTBUS7_CodResp = "" ;
         AV23pTTBUS7_DesResp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         AV25TTBUS7_DesResp = "" ;
         AV20TTBUS7_Des = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtavGttbus7_pos_Internalname = "" ;
         edtavGttbus7_des_Internalname = "" ;
         edtavGttbus7_desresp_Internalname = "" ;
         AV8LinkSelection = "" ;
         AV30gTTBUS7_Des = "" ;
         AV31gTTBUS7_CodResp = "" ;
         AV32gTTBUS7_DesResp = "" ;
         Grid1Container = new GXWebGrid( context);
         AV26fTTBUS7_Des = "" ;
         AV19fTTBUS7_DesResp = "" ;
         scmdbuf = "" ;
         H00082_A40TTBUS8_CodUsuario = new String[] {""} ;
         H00083_A34TTBUS7_Des = new String[] {""} ;
         H00083_n34TTBUS7_Des = new bool[] {false} ;
         H00083_A35TTBUS7_CodResp = new String[] {""} ;
         H00083_A36TTBUS7_DesResp = new String[] {""} ;
         H00083_n36TTBUS7_DesResp = new bool[] {false} ;
         H00083_A33TTBUS7_Pos = new short[1] ;
         H00084_A34TTBUS7_Des = new String[] {""} ;
         H00084_n34TTBUS7_Des = new bool[] {false} ;
         H00084_A35TTBUS7_CodResp = new String[] {""} ;
         H00084_A36TTBUS7_DesResp = new String[] {""} ;
         H00084_n36TTBUS7_DesResp = new bool[] {false} ;
         H00084_A33TTBUS7_Pos = new short[1] ;
         H00085_A39TTBUS7_CodUsuario = new String[] {""} ;
         H00085_A33TTBUS7_Pos = new short[1] ;
         H00085_A51TTBUS7_RespAux = new short[1] ;
         H00086_A34TTBUS7_Des = new String[] {""} ;
         H00086_n34TTBUS7_Des = new bool[] {false} ;
         H00086_A35TTBUS7_CodResp = new String[] {""} ;
         H00086_A36TTBUS7_DesResp = new String[] {""} ;
         H00086_n36TTBUS7_DesResp = new bool[] {false} ;
         H00086_A33TTBUS7_Pos = new short[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char4 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockubi_des_Jsonclick = "" ;
         lblTextblockubi_tip2_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         GXt_char5 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char6 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.httbus_prompt1__default(),
            new Object[][] {
                new Object[] {
               H00082_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               H00083_A34TTBUS7_Des, H00083_n34TTBUS7_Des, H00083_A35TTBUS7_CodResp, H00083_A36TTBUS7_DesResp, H00083_n36TTBUS7_DesResp, H00083_A33TTBUS7_Pos
               }
               , new Object[] {
               H00084_A34TTBUS7_Des, H00084_n34TTBUS7_Des, H00084_A35TTBUS7_CodResp, H00084_A36TTBUS7_DesResp, H00084_n36TTBUS7_DesResp, H00084_A33TTBUS7_Pos
               }
               , new Object[] {
               H00085_A39TTBUS7_CodUsuario, H00085_A33TTBUS7_Pos, H00085_A51TTBUS7_RespAux
               }
               , new Object[] {
               H00086_A34TTBUS7_Des, H00086_n34TTBUS7_Des, H00086_A35TTBUS7_CodResp, H00086_A36TTBUS7_DesResp, H00086_n36TTBUS7_DesResp, H00086_A33TTBUS7_Pos
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavGttbus7_codresp_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_30_idx=1 ;
      private short A51TTBUS7_RespAux ;
      private short A33TTBUS7_Pos ;
      private short AV21pTTBUS7_Pos ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short AV29gTTBUS7_Pos ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short AV33band ;
      private short AV34vTTBUS7_Pos ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize30 ;
      private int edtavGttbus7_codresp_Enabled ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String AV10USUARIO ;
      private String AV35Modo ;
      private String wcpOAV10USUARIO ;
      private String wcpOAV35Modo ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_30_idx="0001" ;
      private String edtavGttbus7_codresp_Internalname ;
      private String A39TTBUS7_CodUsuario ;
      private String A36TTBUS7_DesResp ;
      private String A35TTBUS7_CodResp ;
      private String A34TTBUS7_Des ;
      private String A40TTBUS8_CodUsuario ;
      private String AV22pTTBUS7_Des ;
      private String AV18pTTBUS7_CodResp ;
      private String AV23pTTBUS7_DesResp ;
      private String sDynURL ;
      private String FormProcess ;
      private String AV25TTBUS7_DesResp ;
      private String AV20TTBUS7_Des ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtavGttbus7_pos_Internalname ;
      private String edtavGttbus7_des_Internalname ;
      private String edtavGttbus7_desresp_Internalname ;
      private String AV30gTTBUS7_Des ;
      private String AV31gTTBUS7_CodResp ;
      private String AV32gTTBUS7_DesResp ;
      private String edtavFttbus7_des_Internalname ;
      private String AV26fTTBUS7_Des ;
      private String AV19fTTBUS7_DesResp ;
      private String edtavFttbus7_desresp_Internalname ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String edtavLinkselection_Link ;
      private String GXt_char4 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockubi_des_Internalname ;
      private String lblTextblockubi_des_Jsonclick ;
      private String edtavFttbus7_des_Jsonclick ;
      private String lblTextblockubi_tip2_Internalname ;
      private String lblTextblockubi_tip2_Jsonclick ;
      private String edtavFttbus7_desresp_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String GXt_char5 ;
      private String ROClassString ;
      private String edtavGttbus7_pos_Jsonclick ;
      private String edtavGttbus7_des_Jsonclick ;
      private String edtavGttbus7_codresp_Jsonclick ;
      private String edtavGttbus7_desresp_Jsonclick ;
      private String GXt_char6 ;
      private bool entryPointCalled ;
      private bool n36TTBUS7_DesResp ;
      private bool n34TTBUS7_Des ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV8LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00082_A40TTBUS8_CodUsuario ;
      private String[] H00083_A34TTBUS7_Des ;
      private bool[] H00083_n34TTBUS7_Des ;
      private String[] H00083_A35TTBUS7_CodResp ;
      private String[] H00083_A36TTBUS7_DesResp ;
      private bool[] H00083_n36TTBUS7_DesResp ;
      private short[] H00083_A33TTBUS7_Pos ;
      private String[] H00084_A34TTBUS7_Des ;
      private bool[] H00084_n34TTBUS7_Des ;
      private String[] H00084_A35TTBUS7_CodResp ;
      private String[] H00084_A36TTBUS7_DesResp ;
      private bool[] H00084_n36TTBUS7_DesResp ;
      private short[] H00084_A33TTBUS7_Pos ;
      private String[] H00085_A39TTBUS7_CodUsuario ;
      private short[] H00085_A33TTBUS7_Pos ;
      private short[] H00085_A51TTBUS7_RespAux ;
      private String[] H00086_A34TTBUS7_Des ;
      private bool[] H00086_n34TTBUS7_Des ;
      private String[] H00086_A35TTBUS7_CodResp ;
      private String[] H00086_A36TTBUS7_DesResp ;
      private bool[] H00086_n36TTBUS7_DesResp ;
      private short[] H00086_A33TTBUS7_Pos ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pTTBUS7_Pos ;
      private String aP1_pTTBUS7_Des ;
      private String aP2_pTTBUS7_CodResp ;
      private String aP3_pTTBUS7_DesResp ;
      private GXWebForm Form ;
   }

   public class httbus_prompt1__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00082 ;
          prmH00082 = new Object[] {
          new Object[] {"@AV10USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH00083 ;
          prmH00083 = new Object[] {
          } ;
          Object[] prmH00084 ;
          prmH00084 = new Object[] {
          } ;
          Object[] prmH00085 ;
          prmH00085 = new Object[] {
          new Object[] {"@AV34vTTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV10USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH00086 ;
          prmH00086 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H00082", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV10USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00082,1,0,false,true )
             ,new CursorDef("H00083", "SELECT T3.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[USU_DES] AS TTBUS7_DesResp, T1.[TTBUS7_Pos] AS TTBUS7_Pos FROM (([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) INNER JOIN [T53FPOS] T3 WITH (NOLOCK) ON T3.[W53POS] = T1.[TTBUS7_Pos]) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00083,100,0,false,false )
             ,new CursorDef("H00084", "SELECT T3.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[USU_DES] AS TTBUS7_DesResp, T1.[TTBUS7_Pos] AS TTBUS7_Pos FROM (([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) INNER JOIN [T53FPOS] T3 WITH (NOLOCK) ON T3.[W53POS] = T1.[TTBUS7_Pos]) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00084,100,0,true,false )
             ,new CursorDef("H00085", "SELECT [TTBUS7_CodUsuario], [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_RespAux] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV34vTTBUS7_Pos and [TTBUS7_CodUsuario] = @AV10USUARIO ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00085,1,0,false,true )
             ,new CursorDef("H00086", "SELECT T3.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[USU_DES] AS TTBUS7_DesResp, T1.[TTBUS7_Pos] AS TTBUS7_Pos FROM (([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) INNER JOIN [T53FPOS] T3 WITH (NOLOCK) ON T3.[W53POS] = T1.[TTBUS7_Pos]) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00086,100,0,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
