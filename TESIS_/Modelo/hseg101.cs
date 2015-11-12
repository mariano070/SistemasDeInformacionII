/*
               File: HSEG101
        Description: Actualización de Programas
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:30.62
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class hseg101 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hseg101( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hseg101( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_SISCOD ,
                           ref String aP1_SISDES ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV9SISCOD = aP0_SISCOD;
         this.AV10SISDES = aP1_SISDES;
         this.AV8SISTEMA = aP2_SISTEMA;
         this.AV7USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_SISCOD=this.AV9SISCOD;
         aP1_SISDES=this.AV10SISDES;
         aP2_SISTEMA=this.AV8SISTEMA;
         aP3_USUARIO=this.AV7USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbPRG_EXT = new GXCombobox();
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
               nGXsfl_22_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_22_idx = GetNextPar( ) ;
               edtavDelete_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
               AV20Delete = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV20Delete));
               edtavUpdate_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
               AV19Update = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV19Update));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_22_idx, sGXsfl_22_idx, AV20Delete, AV19Update) ;
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
               AV9SISCOD = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SISCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9SISCOD), 3, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV10SISDES = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SISDES", AV10SISDES);
                  AV8SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SISTEMA", AV8SISTEMA);
                  AV7USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USUARIO", AV7USUARIO);
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA4U2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4U2( ) ;
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
         FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;margin: 0px;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hseg101.aspx") + "?" + UrlEncode("" +AV9SISCOD) + "," + UrlEncode(StringUtil.RTrim(AV10SISDES)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vPRGDES", StringUtil.RTrim( AV6PRGDES));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV8SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV7USUARIO));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE4U2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4U2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HSEG101" ;
      }

      public override String GetPgmdesc( )
      {
         return "Actualización de Programas" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hseg101.aspx") + "?" + UrlEncode("" +AV9SISCOD) + "," + UrlEncode(StringUtil.RTrim(AV10SISDES)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO)) ;
      }

      protected void WB4U0( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            context.WriteHtmlText( "<pre>") ;
            wb_table1_3_4U2( true) ;
         }
         else
         {
            wb_table1_3_4U2( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_4U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<center>") ;
            context.WriteHtmlTextNl( "&nbsp;") ;
            context.WriteHtmlText( "  ") ;
            context.WriteHtmlText( "</center>") ;
            context.WriteHtmlText( "</pre>") ;
         }
         wbLoad = true ;
      }

      protected void START4U2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Actualización de Programas", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP4U0( ) ;
      }

      protected void WS4U2( )
      {
         START4U2( ) ;
         EVT4U2( ) ;
      }

      protected void EVT4U2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vPRGDES"), AV6PRGDES) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
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
                           else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E114U2 */
                              E114U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'MENU X'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E124U2 */
                              E124U2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'ALTA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'MODIFICA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'MENU X'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'MODIFICA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) )
                           {
                              nGXsfl_22_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_22_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_22_idx), 4, 0)), 4, "0") ;
                              edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
                              edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
                              edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_22_idx ;
                              edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_22_idx ;
                              edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_22_idx ;
                              edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
                              cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_22_idx ;
                              AV19Update = cgiGet( "GXimg"+edtavUpdate_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV19Update));
                              AV20Delete = cgiGet( "GXimg"+edtavDelete_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV20Delete));
                              A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                              A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
                              A164PRG_SIS = (short)(context.localUtil.CToN( cgiGet( edtPRG_SIS_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
                              A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
                              n259SIS_DES = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
                              cmbPRG_EXT.Name = cmbPRG_EXT_Internalname ;
                              cmbPRG_EXT.CurrentValue = cgiGet( cmbPRG_EXT_Internalname) ;
                              A128PRG_EXT = cgiGet( cmbPRG_EXT_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E134U2 */
                                    E134U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E114U2 */
                                    E114U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E144U2 */
                                    E144U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MODIFICA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E154U2 */
                                    E154U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E164U2 */
                                    E164U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MENU X'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E124U2 */
                                    E124U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Prgdes Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRGDES"), AV6PRGDES) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
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

      protected void WE4U2( )
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

      protected void PA4U2( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "PRG_EXT_" + sGXsfl_22_idx ;
            cmbPRG_EXT.Name = GXCCtl ;
            cmbPRG_EXT.WebTags = "" ;
            cmbPRG_EXT.addItem("I", "Intranet", 0);
            cmbPRG_EXT.addItem("X", "IntranetX", 0);
            cmbPRG_EXT.addItem("E", "Extranet", 0);
            cmbPRG_EXT.addItem("B", "Baja (inactivo)", 0);
            cmbPRG_EXT.addItem("P", "Permiso Especial", 0);
            if ( ( cmbPRG_EXT.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A128PRG_EXT)) )
            {
               A128PRG_EXT = cmbPRG_EXT.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
            }
            GX_FocusControl = edtavPrgdes_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_22_idx ,
                                       String sGXsfl_22_idx ,
                                       String AV20Delete ,
                                       String AV19Update )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_22_idx ;
         edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_22_idx ;
         edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_22_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
         cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_22_idx ;
         while ( nGXsfl_22_idx <= nRC_Grid1 )
         {
            sendrow_222( ) ;
            nGXsfl_22_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_22_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_22_idx+1)) ;
            sGXsfl_22_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_22_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_22_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_22_idx ;
            edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_22_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_22_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void Refresh( )
      {
         RF4U2( ) ;
         /* End function Refresh */
      }

      protected void RF4U2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 22 ;
         nGXsfl_22_idx = 1 ;
         sGXsfl_22_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_22_idx), 4, 0)), 4, "0") ;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_22_idx ;
         edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_22_idx ;
         edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_22_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
         cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_22_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_22_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_22_idx ;
            edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_22_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_22_idx ;
            lV6PRGDES = StringUtil.PadR( StringUtil.RTrim( AV6PRGDES), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6PRGDES", AV6PRGDES);
            /* Using cursor H004U2 */
            pr_default.execute(0, new Object[] {AV9SISCOD, lV6PRGDES});
            nGXsfl_22_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A128PRG_EXT = H004U2_A128PRG_EXT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
               A259SIS_DES = H004U2_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               n259SIS_DES = H004U2_n259SIS_DES[0] ;
               A164PRG_SIS = H004U2_A164PRG_SIS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
               A127PRG_DES = H004U2_A127PRG_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               A126PRG_COD = H004U2_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A259SIS_DES = H004U2_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               n259SIS_DES = H004U2_n259SIS_DES[0] ;
               /* Execute user event: E164U2 */
               E164U2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 22 ;
            WB4U0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         lV6PRGDES = StringUtil.PadR( StringUtil.RTrim( AV6PRGDES), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6PRGDES", AV6PRGDES);
         /* Using cursor H004U3 */
         pr_default.execute(1, new Object[] {AV9SISCOD, lV6PRGDES});
         GRID1_nRecordCount = H004U3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
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
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
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
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
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

      protected void STRUP4U0( )
      {
         /* Before Start, stand alone formulas. */
         AV26Pgmname = "HSEG101" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E134U2 */
         E134U2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV9SISCOD = (short)(context.localUtil.CToN( cgiGet( edtavSiscod_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SISCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9SISCOD), 3, 0)));
            AV10SISDES = StringUtil.Upper( cgiGet( edtavSisdes_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SISDES", AV10SISDES);
            AV6PRGDES = StringUtil.Upper( cgiGet( edtavPrgdes_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6PRGDES", AV6PRGDES);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV8SISTEMA = cgiGet( "vSISTEMA") ;
            AV7USUARIO = cgiGet( "vUSUARIO") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            nGXsfl_22_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_22_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_22_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_22_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_22_idx ;
            edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_22_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_22_idx ;
            if ( nGXsfl_22_idx > 0 )
            {
               AV19Update = cgiGet( "GXimg"+edtavUpdate_Internalname) ;
               AV20Delete = cgiGet( "GXimg"+edtavDelete_Internalname) ;
               A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               A164PRG_SIS = (short)(context.localUtil.CToN( cgiGet( edtPRG_SIS_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
               A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
               n259SIS_DES = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               cmbPRG_EXT.Name = cmbPRG_EXT_Internalname ;
               cmbPRG_EXT.CurrentValue = cgiGet( cmbPRG_EXT_Internalname) ;
               A128PRG_EXT = cgiGet( cmbPRG_EXT_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E134U2 */
         E134U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E134U2( )
      {
         /* Start Routine */
         AV19Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV19Update));
         edtavUpdate_Tooltiptext = "Modifica" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
         AV20Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV20Delete));
         edtavDelete_Tooltiptext = "Eliminar" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV7USUARIO)) )
         {
            AV7USUARIO = context.GetCookie( "USUARIO") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USUARIO", AV7USUARIO);
         }
         else
         {
            AV12A = context.SetCookie( "USUARIO", AV7USUARIO, "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         AV13Habilitado = 1 ;
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV14TrnContext = new SdtTransactionContext(context) ;
         AV14TrnContext.gxTpr_Callerobject = AV26Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14TrnContext", (Object)(AV14TrnContext));
         AV14TrnContext.gxTpr_Callerondelete = true ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14TrnContext", (Object)(AV14TrnContext));
         AV14TrnContext.gxTpr_Callerurl = AV15HTTPRequest.ScriptName+"?"+AV15HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14TrnContext", (Object)(AV14TrnContext));
         AV14TrnContext.gxTpr_Transactionname = "TSEG001" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14TrnContext", (Object)(AV14TrnContext));
         AV16TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV16TrnContextAtt.gxTpr_Attributename = "PRG_SIS" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16TrnContextAtt", (Object)(AV16TrnContextAtt));
         AV16TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV9SISCOD), 3, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16TrnContextAtt", (Object)(AV16TrnContextAtt));
         AV14TrnContext.gxTpr_Attributes.Add(AV16TrnContextAtt, 0);
         AV17Session.Set("TrnContext", AV14TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void E114U2( )
      {
         /* 'Alta' Routine */
         context.wjLoc = formatLink("tseg001.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +AV5PRGCOD) ;
      }

      protected void E144U2( )
      {
         /* 'Baja' Routine */
         context.wjLoc = formatLink("tseg001.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A126PRG_COD) ;
      }

      protected void E154U2( )
      {
         /* 'Modifica' Routine */
         context.wjLoc = formatLink("tseg001.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A126PRG_COD) ;
      }

      private void E164U2( )
      {
         /* Grid1_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 22 ;
         }
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_222( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void E124U2( )
      {
         /* 'Menu X' Routine */
         AV21GridState.FromXml(AV17Session.Get("WWSEG008"+"GridState"), "");
         AV21GridState.gxTpr_Currentpage = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21GridState", (Object)(AV21GridState));
         AV21GridState.gxTpr_Orderedby = (short)(AV27Orderedby) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21GridState", (Object)(AV21GridState));
         AV21GridState.gxTpr_Filtervalues.Clear();
         AV22GridStateFilterValue = new SdtGridState_FilterValue(context) ;
         AV22GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22GridStateFilterValue", (Object)(AV22GridStateFilterValue));
         AV21GridState.gxTpr_Filtervalues.Add(AV22GridStateFilterValue, 0);
         AV22GridStateFilterValue = new SdtGridState_FilterValue(context) ;
         AV22GridStateFilterValue.gxTpr_Value = A127PRG_DES ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22GridStateFilterValue", (Object)(AV22GridStateFilterValue));
         AV21GridState.gxTpr_Filtervalues.Add(AV22GridStateFilterValue, 0);
         AV22GridStateFilterValue = new SdtGridState_FilterValue(context) ;
         AV22GridStateFilterValue.gxTpr_Value = "" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22GridStateFilterValue", (Object)(AV22GridStateFilterValue));
         AV21GridState.gxTpr_Filtervalues.Add(AV22GridStateFilterValue, 0);
         AV17Session.Set("WWSEG008"+"GridState", AV21GridState.ToXml(false, "GridState", "MarianoTesis"));
         context.wjLoc = formatLink("wwseg008.aspx")  ;
      }

      protected void wb_table1_3_4U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Sistema:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HSEG101.htm");
            context.WriteHtmlText( "&nbsp;&nbsp;&nbsp; &nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavSiscod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9SISCOD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtavSiscod_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV9SISCOD), "ZZ9"), "", 0, edtavSiscod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HSEG101.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavSisdes_Internalname, StringUtil.RTrim( AV10SISDES), "", 15, "chr", 1, "row", 15, 1, edtavSisdes_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10SISDES, "@!")), "", 0, edtavSisdes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG101.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;") ;
            wb_table2_11_4U2( true) ;
         }
         else
         {
            wb_table2_11_4U2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_4U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"top\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", 0);
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal; color:#000000"+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal; color:#000000"+"\" "+">") ;
               context.SendWebValue( "Programa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "CODIGO DE SISTEMA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "Entorno") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "WorkWith");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Titlefont", StringUtil.RTrim( subGrid1_Titlefont));
               Grid1Container.AddObjectProperty("Linesfont", StringUtil.RTrim( subGrid1_Linesfont));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV19Update));
               Grid1Column.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV20Delete));
               Grid1Column.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A127PRG_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A164PRG_SIS), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A259SIS_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A128PRG_EXT));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 22 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_22_idx-1) ;
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
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table3_33_4U2( true) ;
         }
         else
         {
            wb_table3_33_4U2( false) ;
         }
         return  ;
      }

      protected void wb_table3_33_4U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_4U2e( true) ;
         }
         else
         {
            wb_table1_3_4U2e( false) ;
         }
      }

      protected void wb_table3_33_4U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Menu X", "Menu X", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'MENU X\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(22), 3, 0)+","+"null"+");", "", "HLP_HSEG101.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#404040" ;
            GxWebStd.gx_button_ctrl( context, 2, bttButton5_Internalname, "Usuarios", "Usuarios", "", StyleString, ClassString, 1, 1, "rounded", 7, bttButton5_Jsonclick, "'"+""+"'"+",false,"+"'"+"e174u2_client"+"'", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(22), 3, 0)+","+"null"+");", "", "HLP_HSEG101.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#404040" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton4_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttButton4_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(22), 3, 0)+","+"null"+");", "", "HLP_HSEG101.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_33_4U2e( true) ;
         }
         else
         {
            wb_table3_33_4U2e( false) ;
         }
      }

      protected void wb_table2_11_4U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Programa:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HSEG101.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'" + sGXsfl_22_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavPrgdes_Internalname, StringUtil.RTrim( AV6PRGDES), "", 30, "chr", 1, "row", 30, 1, edtavPrgdes_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6PRGDES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(15);\"", 0, edtavPrgdes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG101.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#404040" ;
            GxWebStd.gx_button_ctrl( context, 2, bttButton2_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 7, bttButton2_Jsonclick, "'"+""+"'"+",false,"+"'"+"e184u2_client"+"'", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(22), 3, 0)+","+"null"+");", "", "HLP_HSEG101.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "PagingButtons" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgInsert_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Agrega", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgInsert_Jsonclick, "E\\'ALTA\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HSEG101.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_4U2e( true) ;
         }
         else
         {
            wb_table2_11_4U2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV9SISCOD = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SISCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9SISCOD), 3, 0)));
         AV10SISDES = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SISDES", AV10SISDES);
         AV8SISTEMA = (String)getParm(obj,2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SISTEMA", AV8SISTEMA);
         AV7USUARIO = (String)getParm(obj,3) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USUARIO", AV7USUARIO);
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
         PA4U2( ) ;
         WS4U2( ) ;
         WE4U2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11183121");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("hseg101.js", "?11183121");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_222( )
      {
         WB4U0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_22_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_22_idx) % (2)) == 0 )
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
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavUpdate_Enabled!=0)&&(edtavUpdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 23,'',false,'',22)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)"",(String)AV19Update,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavUpdate_Jsonclick,"E\\'MODIFICA\\'."+sGXsfl_22_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDelete_Enabled!=0)&&(edtavDelete_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 24,'',false,'',22)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)"",(String)AV20Delete,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavDelete_Jsonclick,"E\\'BAJA\\'."+sGXsfl_22_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")),(String)"",(short)96,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)1,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"),(String)"",(short)0,(String)edtPRG_COD_Jsonclick,(String)"",(short)22,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_DES_Internalname,StringUtil.RTrim( A127PRG_DES),(String)"",(short)389,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)1,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRG_DES_Jsonclick,(String)"",(short)22,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_SIS_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A164PRG_SIS), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A164PRG_SIS), "ZZ9"),(String)"",(short)0,(String)edtPRG_SIS_Jsonclick,(String)"",(short)22,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_DES_Internalname,StringUtil.RTrim( A259SIS_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")),(String)"",(short)0,(String)edtSIS_DES_Jsonclick,(String)"",(short)22,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            if ( ( nGXsfl_22_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PRG_EXT_" + sGXsfl_22_idx ;
               cmbPRG_EXT.Name = GXCCtl ;
               cmbPRG_EXT.WebTags = "" ;
               cmbPRG_EXT.addItem("I", "Intranet", 0);
               cmbPRG_EXT.addItem("X", "IntranetX", 0);
               cmbPRG_EXT.addItem("E", "Extranet", 0);
               cmbPRG_EXT.addItem("B", "Baja (inactivo)", 0);
               cmbPRG_EXT.addItem("P", "Permiso Especial", 0);
               if ( ( cmbPRG_EXT.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A128PRG_EXT)) )
               {
                  A128PRG_EXT = cmbPRG_EXT.getItemValue(1) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPRG_EXT,(String)cmbPRG_EXT_Internalname,(String)A128PRG_EXT,(String)"",(String)"char",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbPRG_EXT_Jsonclick,(String)"",(String)"",(bool)true});
            cmbPRG_EXT.CurrentValue = A128PRG_EXT ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPRG_EXT_Internalname, "Values", (String)(cmbPRG_EXT.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_22_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_22_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_22_idx+1)) ;
            sGXsfl_22_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_22_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_22_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_22_idx ;
            edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_22_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_22_idx ;
         }
         /* End function sendrow_222 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavSiscod_Internalname = "vSISCOD" ;
         edtavSisdes_Internalname = "vSISDES" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavPrgdes_Internalname = "vPRGDES" ;
         bttButton2_Internalname = "BUTTON2" ;
         imgInsert_Internalname = "INSERT" ;
         tblTable3_Internalname = "TABLE3" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton5_Internalname = "BUTTON5" ;
         bttButton4_Internalname = "BUTTON4" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable2_Internalname = "TABLE2" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         cmbPRG_EXT_Jsonclick = "" ;
         edtSIS_DES_Jsonclick = "" ;
         edtPRG_SIS_Jsonclick = "" ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_COD_Jsonclick = "" ;
         edtavDelete_Jsonclick = "" ;
         edtavDelete_Visible = -1 ;
         edtavDelete_Enabled = 1 ;
         edtavUpdate_Jsonclick = "" ;
         edtavUpdate_Visible = -1 ;
         edtavUpdate_Enabled = 1 ;
         edtavPrgdes_Jsonclick = "" ;
         edtavPrgdes_Backstyle = -1 ;
         edtavPrgdes_Backcolor = (int)(0xFFFFFF) ;
         edtavPrgdes_Enabled = 1 ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         subGrid1_Linesfont = "font-family:Courier New;font-size:9pt;" ;
         subGrid1_Titlefont = "font-family:Arial;font-size:9pt;font-weight:bold;" ;
         subGrid1_Class = "WorkWith" ;
         subGrid1_Backcolorstyle = 3 ;
         edtavSisdes_Jsonclick = "" ;
         edtavSisdes_Backstyle = -1 ;
         edtavSisdes_Backcolor = (int)(0xFFFFFF) ;
         edtavSisdes_Enabled = 0 ;
         edtavSiscod_Jsonclick = "" ;
         edtavSiscod_Backstyle = -1 ;
         edtavSiscod_Backcolor = (int)(0xFFFFFF) ;
         edtavSiscod_Enabled = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Actualización de Programas" ;
         edtavUpdate_Tooltiptext = "" ;
         edtavDelete_Tooltiptext = "" ;
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
         wcpOAV10SISDES = "" ;
         wcpOAV8SISTEMA = "" ;
         wcpOAV7USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         edtavDelete_Internalname = "" ;
         AV20Delete = "" ;
         edtavUpdate_Internalname = "" ;
         AV19Update = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         AV6PRGDES = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtPRG_COD_Internalname = "" ;
         edtPRG_DES_Internalname = "" ;
         edtPRG_SIS_Internalname = "" ;
         edtSIS_DES_Internalname = "" ;
         cmbPRG_EXT_Internalname = "" ;
         A127PRG_DES = "" ;
         A259SIS_DES = "" ;
         A128PRG_EXT = "" ;
         GXCCtl = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6PRGDES = "" ;
         H004U2_A128PRG_EXT = new String[] {""} ;
         H004U2_A259SIS_DES = new String[] {""} ;
         H004U2_n259SIS_DES = new bool[] {false} ;
         H004U2_A164PRG_SIS = new short[1] ;
         H004U2_A127PRG_DES = new String[] {""} ;
         H004U2_A126PRG_COD = new short[1] ;
         H004U3_AGRID1_nRecordCount = new int[1] ;
         AV26Pgmname = "" ;
         AV14TrnContext = new SdtTransactionContext(context);
         AV15HTTPRequest = new GxHttpRequest( context);
         AV16TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV17Session = new GxWebSession( context);
         AV21GridState = new SdtGridState(context);
         AV22GridStateFilterValue = new SdtGridState_FilterValue(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char6 = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton5_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         imgInsert_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char7 = "" ;
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hseg101__default(),
            new Object[][] {
                new Object[] {
               H004U2_A128PRG_EXT, H004U2_A259SIS_DES, H004U2_n259SIS_DES, H004U2_A164PRG_SIS, H004U2_A127PRG_DES, H004U2_A126PRG_COD
               }
               , new Object[] {
               H004U3_AGRID1_nRecordCount
               }
            }
         );
         AV26Pgmname = "HSEG101" ;
         /* GeneXus formulas. */
         AV26Pgmname = "HSEG101" ;
         context.Gx_err = 0 ;
      }

      private short AV9SISCOD ;
      private short wcpOAV9SISCOD ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_22_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A126PRG_COD ;
      private short A164PRG_SIS ;
      private short nDonePA ;
      private short AV12A ;
      private short AV13Habilitado ;
      private short AV5PRGCOD ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private short edtavPrgdes_Backstyle ;
      private short edtavSisdes_Backstyle ;
      private short edtavSiscod_Backstyle ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int edtavSiscod_Enabled ;
      private int edtavSisdes_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int edtavPrgdes_Enabled ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavUpdate_Enabled ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Enabled ;
      private int edtavDelete_Visible ;
      private int edtavPrgdes_Backcolor ;
      private int edtavSisdes_Backcolor ;
      private int edtavSiscod_Backcolor ;
      private decimal AV27Orderedby ;
      private String AV10SISDES ;
      private String AV8SISTEMA ;
      private String AV7USUARIO ;
      private String wcpOAV10SISDES ;
      private String wcpOAV8SISTEMA ;
      private String wcpOAV7USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_22_idx="0001" ;
      private String edtavDelete_Tooltiptext ;
      private String edtavDelete_Internalname ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavUpdate_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String AV6PRGDES ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_DES_Internalname ;
      private String edtPRG_SIS_Internalname ;
      private String edtSIS_DES_Internalname ;
      private String cmbPRG_EXT_Internalname ;
      private String A127PRG_DES ;
      private String A259SIS_DES ;
      private String A128PRG_EXT ;
      private String GXCCtl ;
      private String edtavPrgdes_Internalname ;
      private String scmdbuf ;
      private String lV6PRGDES ;
      private String AV26Pgmname ;
      private String edtavSiscod_Internalname ;
      private String edtavSisdes_Internalname ;
      private String subGrid1_Internalname ;
      private String sStyleString ;
      private String tblTable2_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavSiscod_Jsonclick ;
      private String edtavSisdes_Jsonclick ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String GXt_char6 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton5_Internalname ;
      private String bttButton5_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavPrgdes_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String imgInsert_Internalname ;
      private String imgInsert_Jsonclick ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String GXt_char7 ;
      private String ROClassString ;
      private String edtPRG_COD_Jsonclick ;
      private String edtPRG_DES_Jsonclick ;
      private String edtPRG_SIS_Jsonclick ;
      private String edtSIS_DES_Jsonclick ;
      private String cmbPRG_EXT_Jsonclick ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n259SIS_DES ;
      private bool returnInSub ;
      private String AV20Delete ;
      private String AV19Update ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private short aP0_SISCOD ;
      private String aP1_SISDES ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private GXCombobox cmbPRG_EXT ;
      private IDataStoreProvider pr_default ;
      private String[] H004U2_A128PRG_EXT ;
      private String[] H004U2_A259SIS_DES ;
      private bool[] H004U2_n259SIS_DES ;
      private short[] H004U2_A164PRG_SIS ;
      private String[] H004U2_A127PRG_DES ;
      private short[] H004U2_A126PRG_COD ;
      private int[] H004U3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV15HTTPRequest ;
      private GxWebSession AV17Session ;
      private GXWebForm Form ;
      private SdtTransactionContext AV14TrnContext ;
      private SdtTransactionContext_Attribute AV16TrnContextAtt ;
      private SdtGridState AV21GridState ;
      private SdtGridState_FilterValue AV22GridStateFilterValue ;
   }

   public class hseg101__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH004U2 ;
          prmH004U2 = new Object[] {
          new Object[] {"@AV9SISCOD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV6PRGDES",SqlDbType.Char,30,0}
          } ;
          Object[] prmH004U3 ;
          prmH004U3 = new Object[] {
          new Object[] {"@AV9SISCOD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV6PRGDES",SqlDbType.Char,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004U2", "SELECT T1.[PRG_EXT], T2.[SIS_DES], T1.[PRG_SIS] AS PRG_SIS, T1.[PRG_DES], T1.[PRG_COD] FROM ([SEG001] T1 WITH (NOLOCK) INNER JOIN [SEG000] T2 WITH (NOLOCK) ON T2.[SIS_COD] = T1.[PRG_SIS]) WHERE (T1.[PRG_SIS] = @AV9SISCOD) AND (T1.[PRG_DES] like @AV6PRGDES) ORDER BY T1.[PRG_DES]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004U2,11,1,true,false )
             ,new CursorDef("H004U3", "SELECT COUNT(*) FROM ([SEG001] T1 WITH (NOLOCK) INNER JOIN [SEG000] T2 WITH (NOLOCK) ON T2.[SIS_COD] = T1.[PRG_SIS]) WHERE (T1.[PRG_SIS] = @AV9SISCOD) AND (T1.[PRG_DES] like @AV6PRGDES) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004U3,1,1,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((String[]) buf[4])[0] = rslt.getString(4, 30) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
