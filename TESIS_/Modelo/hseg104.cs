/*
               File: HSEG104
        Description: Act. Usuario/Sistema/Programa
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:33.9
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
   public class hseg104 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hseg104( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hseg104( IGxContext context )
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

      public void execute( ref String aP0_USUCOD ,
                           ref String aP1_USUDES ,
                           ref short aP2_SISCOD ,
                           ref String aP3_SISDES ,
                           ref String aP4_SISTEMA ,
                           ref String aP5_USUARIO )
      {
         this.AV5USUCOD = aP0_USUCOD;
         this.AV6USUDES = aP1_USUDES;
         this.AV9SISCOD = aP2_SISCOD;
         this.AV10SISDES = aP3_SISDES;
         this.AV8SISTEMA = aP4_SISTEMA;
         this.AV7USUARIO = aP5_USUARIO;
         executePrivate();
         aP0_USUCOD=this.AV5USUCOD;
         aP1_USUDES=this.AV6USUDES;
         aP2_SISCOD=this.AV9SISCOD;
         aP3_SISDES=this.AV10SISDES;
         aP4_SISTEMA=this.AV8SISTEMA;
         aP5_USUARIO=this.AV7USUARIO;
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
               nGXsfl_17_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_17_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_17_idx, sGXsfl_17_idx) ;
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
               AV5USUCOD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUCOD", AV5USUCOD);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV6USUDES = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUDES", AV6USUDES);
                  AV9SISCOD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SISCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9SISCOD), 3, 0)));
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
         PA522( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START522( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;margin: 0px;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hseg104.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5USUCOD)) + "," + UrlEncode(StringUtil.RTrim(AV6USUDES)) + "," + UrlEncode("" +AV9SISCOD) + "," + UrlEncode(StringUtil.RTrim(AV10SISDES)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
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
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE522( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT522( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HSEG104" ;
      }

      public override String GetPgmdesc( )
      {
         return "Act. Usuario/Sistema/Programa" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hseg104.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5USUCOD)) + "," + UrlEncode(StringUtil.RTrim(AV6USUDES)) + "," + UrlEncode("" +AV9SISCOD) + "," + UrlEncode(StringUtil.RTrim(AV10SISDES)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO)) ;
      }

      protected void WB520( )
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
            wb_table1_3_522( true) ;
         }
         else
         {
            wb_table1_3_522( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_522e( bool wbgen )
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

      protected void START522( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Act. Usuario/Sistema/Programa", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP520( ) ;
      }

      protected void WS522( )
      {
         START522( ) ;
         EVT522( ) ;
      }

      protected void EVT522( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11522 */
                              E11522 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12522 */
                              E12522 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'MODIFICA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E13522 */
                              E13522 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'AGREGA PROGRAMAS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E14522 */
                              E14522 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'ALTA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'MODIFICA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "'AGREGA PROGRAMAS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_17_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_17_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_17_idx), 4, 0)), 4, "0") ;
                              edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_17_idx ;
                              edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_17_idx ;
                              cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_17_idx ;
                              edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_17_idx ;
                              edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_17_idx ;
                              edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_17_idx ;
                              edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_17_idx ;
                              edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_17_idx ;
                              A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                              A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
                              cmbPRG_EXT.Name = cmbPRG_EXT_Internalname ;
                              cmbPRG_EXT.CurrentValue = cgiGet( cmbPRG_EXT_Internalname) ;
                              A128PRG_EXT = cgiGet( cmbPRG_EXT_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
                              A117PRG_WEB = cgiGet( edtPRG_WEB_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
                              A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                              A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
                              A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                              A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E15522 */
                                    E15522 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11522 */
                                    E11522 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MODIFICA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13522 */
                                    E13522 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12522 */
                                    E12522 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'AGREGA PROGRAMAS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E14522 */
                                    E14522 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E16522 */
                                    E16522 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
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

      protected void WE522( )
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

      protected void PA522( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "PRG_EXT_" + sGXsfl_17_idx ;
            cmbPRG_EXT.Name = GXCCtl ;
            cmbPRG_EXT.WebTags = "" ;
            if ( ( cmbPRG_EXT.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A128PRG_EXT)) )
            {
               A128PRG_EXT = cmbPRG_EXT.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
            }
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_17_idx ,
                                       String sGXsfl_17_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_17_idx ;
         edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_17_idx ;
         cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_17_idx ;
         edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_17_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_17_idx ;
         edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_17_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_17_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_17_idx ;
         while ( nGXsfl_17_idx <= nRC_Grid1 )
         {
            sendrow_172( ) ;
            nGXsfl_17_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_17_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_17_idx+1)) ;
            sGXsfl_17_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_17_idx), 4, 0)), 4, "0") ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_17_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_17_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_17_idx ;
            edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_17_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_17_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_17_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_17_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_17_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void Refresh( )
      {
         RF522( ) ;
         /* End function Refresh */
      }

      protected void RF522( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 17 ;
         nGXsfl_17_idx = 1 ;
         sGXsfl_17_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_17_idx), 4, 0)), 4, "0") ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_17_idx ;
         edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_17_idx ;
         cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_17_idx ;
         edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_17_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_17_idx ;
         edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_17_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_17_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_17_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_17_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_17_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_17_idx ;
            edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_17_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_17_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_17_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_17_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_17_idx ;
            /* Using cursor H00522 */
            pr_default.execute(0, new Object[] {AV5USUCOD, AV9SISCOD});
            nGXsfl_17_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 9 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A259SIS_DES = H00522_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               A116SIS_COD = H00522_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A7USU_DES = H00522_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = H00522_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A117PRG_WEB = H00522_A117PRG_WEB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
               A128PRG_EXT = H00522_A128PRG_EXT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
               A127PRG_DES = H00522_A127PRG_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               A126PRG_COD = H00522_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A259SIS_DES = H00522_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               A7USU_DES = H00522_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A117PRG_WEB = H00522_A117PRG_WEB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
               A128PRG_EXT = H00522_A128PRG_EXT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
               A127PRG_DES = H00522_A127PRG_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               /* Execute user event: E16522 */
               E16522 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 17 ;
            WB520( ) ;
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
         /* Using cursor H00523 */
         pr_default.execute(1, new Object[] {AV5USUCOD, AV9SISCOD});
         GRID1_nRecordCount = H00523_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 9 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(9*1) ;
            }
            else
            {
               return (int)(9) ;
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

      protected void STRUP520( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E15522 */
         E15522 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV5USUCOD = StringUtil.Upper( cgiGet( edtavUsucod_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUCOD", AV5USUCOD);
            AV6USUDES = StringUtil.Upper( cgiGet( edtavUsudes_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUDES", AV6USUDES);
            AV9SISCOD = (short)(context.localUtil.CToN( cgiGet( edtavSiscod_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SISCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9SISCOD), 3, 0)));
            AV10SISDES = StringUtil.Upper( cgiGet( edtavSisdes_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SISDES", AV10SISDES);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV8SISTEMA = cgiGet( "vSISTEMA") ;
            AV7USUARIO = cgiGet( "vUSUARIO") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            nGXsfl_17_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_17_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_17_idx), 4, 0)), 4, "0") ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_17_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_17_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_17_idx ;
            edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_17_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_17_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_17_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_17_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_17_idx ;
            if ( nGXsfl_17_idx > 0 )
            {
               A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               cmbPRG_EXT.Name = cmbPRG_EXT_Internalname ;
               cmbPRG_EXT.CurrentValue = cgiGet( cmbPRG_EXT_Internalname) ;
               A128PRG_EXT = cgiGet( cmbPRG_EXT_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
               A117PRG_WEB = cgiGet( edtPRG_WEB_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
               A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
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
         /* Execute user event: E15522 */
         E15522 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E15522( )
      {
         /* Start Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV7USUARIO)) )
         {
            AV7USUARIO = context.GetCookie( "USUARIO") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USUARIO", AV7USUARIO);
         }
         else
         {
            AV13A = context.SetCookie( "USUARIO", AV7USUARIO, "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         AV14Habilitado = 1 ;
         if ( AV14Habilitado == 1 )
         {
            bttBtn_alta_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_alta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_alta_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_alta_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_alta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_alta_Enabled), 5, 0)));
         }
      }

      protected void E11522( )
      {
         /* 'Alta' Routine */
         GXt_int4 = AV11PRGCOD ;
         GXt_char3 = "PG" ;
         new psegu01(context ).execute( ref  GXt_int4, ref  GXt_char3) ;
         AV11PRGCOD = (short)(Convert.ToInt16(GXt_int4)) ;
         context.wjLoc = formatLink("tseg004.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5USUCOD)) + "," + UrlEncode("" +AV9SISCOD) + "," + UrlEncode("" +AV11PRGCOD) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO)) + "," + UrlEncode(StringUtil.RTrim("INS")) ;
      }

      protected void E13522( )
      {
         /* 'Modifica' Routine */
         context.wjLoc = formatLink("tseg004.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO)) + "," + UrlEncode(StringUtil.RTrim("UPD")) ;
      }

      protected void E12522( )
      {
         /* 'Baja' Routine */
         context.wjLoc = formatLink("tseg004.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO)) + "," + UrlEncode(StringUtil.RTrim("DLT")) ;
      }

      protected void E14522( )
      {
         /* 'Agrega Programas' Routine */
         context.wjLoc = formatLink("hseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5USUCOD)) + "," + UrlEncode("" +AV9SISCOD) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO)) ;
      }

      private void E16522( )
      {
         /* Load Routine */
         if ( StringUtil.StrCmp(A128PRG_EXT, "B") == 0 )
         {
            edtPRG_COD_Forecolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Forecolor), 9, 0)));
            edtPRG_COD_Fontbold = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_COD_Fontbold), 1, 0));
            edtPRG_DES_Forecolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_DES_Forecolor), 9, 0)));
            edtPRG_DES_Fontbold = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_DES_Fontbold), 1, 0));
            edtPRG_WEB_Forecolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_WEB_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_WEB_Forecolor), 9, 0)));
            edtPRG_WEB_Fontbold = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_WEB_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_WEB_Fontbold), 1, 0));
         }
         else
         {
            edtPRG_COD_Forecolor = GXUtil.RGB( 0, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Forecolor), 9, 0)));
            edtPRG_COD_Fontbold = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_COD_Fontbold), 1, 0));
            edtPRG_DES_Forecolor = GXUtil.RGB( 0, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_DES_Forecolor), 9, 0)));
            edtPRG_DES_Fontbold = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_DES_Fontbold), 1, 0));
            edtPRG_WEB_Forecolor = GXUtil.RGB( 0, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_WEB_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_WEB_Forecolor), 9, 0)));
            edtPRG_WEB_Fontbold = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_WEB_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_WEB_Fontbold), 1, 0));
         }
         if ( ( subGrid1_Islastpage == 1 ) || ( 9 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_172( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void wb_table1_3_522( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Usuario:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HSEG104.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavUsucod_Internalname, StringUtil.RTrim( AV5USUCOD), "", 16, "chr", 1, "row", 16, 1, edtavUsucod_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV5USUCOD, "@!")), "", 0, edtavUsucod_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG104.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavUsudes_Internalname, StringUtil.RTrim( AV6USUDES), "", 50, "chr", 1, "row", 50, 1, edtavUsudes_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6USUDES, "@!")), "", 0, edtavUsudes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG104.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Sistema:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HSEG104.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavSiscod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9SISCOD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtavSiscod_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV9SISCOD), "ZZ9"), "", 0, edtavSiscod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HSEG104.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavSisdes_Internalname, StringUtil.RTrim( AV10SISDES), "", 15, "chr", 1, "row", 15, 1, edtavSisdes_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10SISDES, "@!")), "", 0, edtavSisdes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG104.htm");
            context.WriteHtmlText( "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal; color:#000000"+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal; color:#000000"+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "Entorno Publicación") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "Nombre Objeto Web") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Forecolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_COD_Forecolor), 9, 0, ".", "")));
               Grid1Column.AddObjectProperty("Fontbold", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_COD_Fontbold), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A127PRG_DES));
               Grid1Column.AddObjectProperty("Forecolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_DES_Forecolor), 9, 0, ".", "")));
               Grid1Column.AddObjectProperty("Fontbold", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_DES_Fontbold), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A128PRG_EXT));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A117PRG_WEB));
               Grid1Column.AddObjectProperty("Forecolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_WEB_Forecolor), 9, 0, ".", "")));
               Grid1Column.AddObjectProperty("Fontbold", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_WEB_Fontbold), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A6USU_COD));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A7USU_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A259SIS_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 17 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_17_idx-1) ;
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
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table2_28_522( true) ;
         }
         else
         {
            wb_table2_28_522( false) ;
         }
         return  ;
      }

      protected void wb_table2_28_522e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_522e( true) ;
         }
         else
         {
            wb_table1_3_522e( false) ;
         }
      }

      protected void wb_table2_28_522( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_alta_Internalname, "Alta", "Alta", "", StyleString, ClassString, 1, bttBtn_alta_Enabled, "rounded", 5, bttBtn_alta_Jsonclick, "E\\'ALTA\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(17), 3, 0)+","+"null"+");", "", "HLP_HSEG104.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Baja", "Baja", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'BAJA\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(17), 3, 0)+","+"null"+");", "", "HLP_HSEG104.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton2_Internalname, "Modifica", "Modifica", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton2_Jsonclick, "E\\'MODIFICA\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(17), 3, 0)+","+"null"+");", "", "HLP_HSEG104.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton3_Internalname, "Agrega Programas", "Agrega Programas", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton3_Jsonclick, "E\\'AGREGA PROGRAMAS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(17), 3, 0)+","+"null"+");", "", "HLP_HSEG104.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton4_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttButton4_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(17), 3, 0)+","+"null"+");", "", "HLP_HSEG104.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_28_522e( true) ;
         }
         else
         {
            wb_table2_28_522e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV5USUCOD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUCOD", AV5USUCOD);
         AV6USUDES = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUDES", AV6USUDES);
         AV9SISCOD = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SISCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9SISCOD), 3, 0)));
         AV10SISDES = (String)getParm(obj,3) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SISDES", AV10SISDES);
         AV8SISTEMA = (String)getParm(obj,4) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SISTEMA", AV8SISTEMA);
         AV7USUARIO = (String)getParm(obj,5) ;
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
         PA522( ) ;
         WS522( ) ;
         WE522( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11183373");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("hseg104.js", "?11183373");
         /* End function include_jscripts */
      }

      protected void sendrow_172( )
      {
         WB520( ) ;
         if ( ( 9 * 1 == 0 ) || ( nGXsfl_17_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_17_idx) % (2)) == 0 )
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((edtPRG_COD_Fontbold==1) ? "font-weight:bold;" : "font-weight:normal;") + "color:" + context.BuildHTMLColor( edtPRG_COD_Forecolor) + ";" + "font-family:'Courier New'; font-size:9.0pt; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")),(String)"",(short)68,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)1,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"),(String)"",(short)0,(String)edtPRG_COD_Jsonclick,(String)"",(short)17,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((edtPRG_DES_Fontbold==1) ? "font-weight:bold;" : "font-weight:normal;") + "color:" + context.BuildHTMLColor( edtPRG_DES_Forecolor) + ";" + "font-family:'Courier New'; font-size:9.0pt; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_DES_Internalname,StringUtil.RTrim( A127PRG_DES),(String)"",(short)445,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)1,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRG_DES_Jsonclick,(String)"",(short)17,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            GXCCtl = "PRG_EXT_" + sGXsfl_17_idx ;
            cmbPRG_EXT.Name = GXCCtl ;
            cmbPRG_EXT.WebTags = "" ;
            if ( ( cmbPRG_EXT.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A128PRG_EXT)) )
            {
               A128PRG_EXT = cmbPRG_EXT.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPRG_EXT,(String)cmbPRG_EXT_Internalname,(String)A128PRG_EXT,(String)"",(String)"char",(short)-1,(short)0,(short)1,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbPRG_EXT_Jsonclick,(String)"",(String)"",(bool)true});
            cmbPRG_EXT.CurrentValue = A128PRG_EXT ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPRG_EXT_Internalname, "Values", (String)(cmbPRG_EXT.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((edtPRG_WEB_Fontbold==1) ? "font-weight:bold;" : "font-weight:normal;") + "color:" + context.BuildHTMLColor( edtPRG_WEB_Forecolor) + ";" + "font-family:'Courier New'; font-size:9.0pt; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_WEB_Internalname,StringUtil.RTrim( A117PRG_WEB),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A117PRG_WEB, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRG_WEB_Jsonclick,(String)"",(short)17,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_COD_Internalname,StringUtil.RTrim( A6USU_COD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")),(String)"",(short)0,(String)edtUSU_COD_Jsonclick,(String)"",(short)17,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_DES_Internalname,StringUtil.RTrim( A7USU_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")),(String)"",(short)0,(String)edtUSU_DES_Jsonclick,(String)"",(short)17,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"),(String)"",(short)0,(String)edtSIS_COD_Jsonclick,(String)"",(short)17,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_DES_Internalname,StringUtil.RTrim( A259SIS_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")),(String)"",(short)0,(String)edtSIS_DES_Jsonclick,(String)"",(short)17,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_17_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_17_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_17_idx+1)) ;
            sGXsfl_17_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_17_idx), 4, 0)), 4, "0") ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_17_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_17_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_17_idx ;
            edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_17_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_17_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_17_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_17_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_17_idx ;
         }
         /* End function sendrow_172 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavUsucod_Internalname = "vUSUCOD" ;
         edtavUsudes_Internalname = "vUSUDES" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavSiscod_Internalname = "vSISCOD" ;
         edtavSisdes_Internalname = "vSISDES" ;
         bttBtn_alta_Internalname = "BTN_ALTA" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton2_Internalname = "BUTTON2" ;
         bttButton3_Internalname = "BUTTON3" ;
         bttButton4_Internalname = "BUTTON4" ;
         tblTable1_Internalname = "TABLE1" ;
         tblTable2_Internalname = "TABLE2" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_COD_Jsonclick = "" ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtPRG_WEB_Jsonclick = "" ;
         cmbPRG_EXT_Jsonclick = "" ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_COD_Jsonclick = "" ;
         bttBtn_alta_Enabled = 1 ;
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
         edtavUsudes_Jsonclick = "" ;
         edtavUsudes_Backstyle = -1 ;
         edtavUsudes_Backcolor = (int)(0xFFFFFF) ;
         edtavUsudes_Enabled = 0 ;
         edtavUsucod_Jsonclick = "" ;
         edtavUsucod_Backstyle = -1 ;
         edtavUsucod_Backcolor = (int)(0xFFFFFF) ;
         edtavUsucod_Enabled = 0 ;
         edtPRG_WEB_Fontbold = 0 ;
         edtPRG_WEB_Forecolor = (int)(0x000000) ;
         edtPRG_DES_Fontbold = 0 ;
         edtPRG_DES_Forecolor = (int)(0x000000) ;
         edtPRG_COD_Fontbold = 0 ;
         edtPRG_COD_Forecolor = (int)(0x000000) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Act. Usuario/Sistema/Programa" ;
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
         wcpOAV5USUCOD = "" ;
         wcpOAV6USUDES = "" ;
         wcpOAV10SISDES = "" ;
         wcpOAV8SISTEMA = "" ;
         wcpOAV7USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtPRG_COD_Internalname = "" ;
         edtPRG_DES_Internalname = "" ;
         cmbPRG_EXT_Internalname = "" ;
         edtPRG_WEB_Internalname = "" ;
         edtUSU_COD_Internalname = "" ;
         edtUSU_DES_Internalname = "" ;
         edtSIS_COD_Internalname = "" ;
         edtSIS_DES_Internalname = "" ;
         A127PRG_DES = "" ;
         A128PRG_EXT = "" ;
         A117PRG_WEB = "" ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         A259SIS_DES = "" ;
         GXCCtl = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H00522_A259SIS_DES = new String[] {""} ;
         H00522_A116SIS_COD = new short[1] ;
         H00522_A7USU_DES = new String[] {""} ;
         H00522_A6USU_COD = new String[] {""} ;
         H00522_A117PRG_WEB = new String[] {""} ;
         H00522_A128PRG_EXT = new String[] {""} ;
         H00522_A127PRG_DES = new String[] {""} ;
         H00522_A126PRG_COD = new short[1] ;
         H00523_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char9 = "" ;
         GXt_char8 = "" ;
         TempTags = "" ;
         bttBtn_alta_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char10 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hseg104__default(),
            new Object[][] {
                new Object[] {
               H00522_A259SIS_DES, H00522_A116SIS_COD, H00522_A7USU_DES, H00522_A6USU_COD, H00522_A117PRG_WEB, H00522_A128PRG_EXT, H00522_A127PRG_DES, H00522_A126PRG_COD
               }
               , new Object[] {
               H00523_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9SISCOD ;
      private short wcpOAV9SISCOD ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_17_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A126PRG_COD ;
      private short A116SIS_COD ;
      private short nDonePA ;
      private short AV13A ;
      private short AV14Habilitado ;
      private short AV11PRGCOD ;
      private short edtPRG_COD_Fontbold ;
      private short edtPRG_DES_Fontbold ;
      private short edtPRG_WEB_Fontbold ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private short edtavSisdes_Backstyle ;
      private short edtavSiscod_Backstyle ;
      private short edtavUsudes_Backstyle ;
      private short edtavUsucod_Backstyle ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int bttBtn_alta_Enabled ;
      private int edtPRG_COD_Forecolor ;
      private int edtPRG_DES_Forecolor ;
      private int edtPRG_WEB_Forecolor ;
      private int edtavUsucod_Enabled ;
      private int edtavUsudes_Enabled ;
      private int edtavSiscod_Enabled ;
      private int edtavSisdes_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavSisdes_Backcolor ;
      private int edtavSiscod_Backcolor ;
      private int edtavUsudes_Backcolor ;
      private int edtavUsucod_Backcolor ;
      private long GXt_int4 ;
      private String AV5USUCOD ;
      private String AV6USUDES ;
      private String AV10SISDES ;
      private String AV8SISTEMA ;
      private String AV7USUARIO ;
      private String wcpOAV5USUCOD ;
      private String wcpOAV6USUDES ;
      private String wcpOAV10SISDES ;
      private String wcpOAV8SISTEMA ;
      private String wcpOAV7USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_17_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_DES_Internalname ;
      private String cmbPRG_EXT_Internalname ;
      private String edtPRG_WEB_Internalname ;
      private String edtUSU_COD_Internalname ;
      private String edtUSU_DES_Internalname ;
      private String edtSIS_COD_Internalname ;
      private String edtSIS_DES_Internalname ;
      private String A127PRG_DES ;
      private String A128PRG_EXT ;
      private String A117PRG_WEB ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String A259SIS_DES ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String edtavUsucod_Internalname ;
      private String edtavUsudes_Internalname ;
      private String edtavSiscod_Internalname ;
      private String edtavSisdes_Internalname ;
      private String subGrid1_Internalname ;
      private String bttBtn_alta_Internalname ;
      private String sStyleString ;
      private String tblTable2_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavUsucod_Jsonclick ;
      private String edtavUsudes_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavSiscod_Jsonclick ;
      private String edtavSisdes_Jsonclick ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String GXt_char9 ;
      private String GXt_char8 ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_alta_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String ROClassString ;
      private String edtPRG_COD_Jsonclick ;
      private String edtPRG_DES_Jsonclick ;
      private String cmbPRG_EXT_Jsonclick ;
      private String edtPRG_WEB_Jsonclick ;
      private String edtUSU_COD_Jsonclick ;
      private String edtUSU_DES_Jsonclick ;
      private String edtSIS_COD_Jsonclick ;
      private String edtSIS_DES_Jsonclick ;
      private String GXt_char10 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_USUCOD ;
      private String aP1_USUDES ;
      private short aP2_SISCOD ;
      private String aP3_SISDES ;
      private String aP4_SISTEMA ;
      private String aP5_USUARIO ;
      private GXCombobox cmbPRG_EXT ;
      private IDataStoreProvider pr_default ;
      private String[] H00522_A259SIS_DES ;
      private short[] H00522_A116SIS_COD ;
      private String[] H00522_A7USU_DES ;
      private String[] H00522_A6USU_COD ;
      private String[] H00522_A117PRG_WEB ;
      private String[] H00522_A128PRG_EXT ;
      private String[] H00522_A127PRG_DES ;
      private short[] H00522_A126PRG_COD ;
      private int[] H00523_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class hseg104__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00522 ;
          prmH00522 = new Object[] {
          new Object[] {"@AV5USUCOD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV9SISCOD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH00523 ;
          prmH00523 = new Object[] {
          new Object[] {"@AV5USUCOD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV9SISCOD",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00522", "SELECT T2.[SIS_DES], T1.[SIS_COD], T3.[USU_DES], T1.[USU_COD], T4.[PRG_WEB], T4.[PRG_EXT], T4.[PRG_DES], T1.[PRG_COD] FROM ((([SEG004] T1 WITH (NOLOCK) INNER JOIN [SEG000] T2 WITH (NOLOCK) ON T2.[SIS_COD] = T1.[SIS_COD]) INNER JOIN [SEG002] T3 WITH (NOLOCK) ON T3.[USU_COD] = T1.[USU_COD]) INNER JOIN [SEG001] T4 WITH (NOLOCK) ON T4.[PRG_COD] = T1.[PRG_COD]) WHERE T1.[USU_COD] = @AV5USUCOD and T1.[SIS_COD] = @AV9SISCOD ORDER BY T1.[USU_COD], T1.[SIS_COD], T1.[PRG_COD]  OPTION (FAST 10)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00522,10,0,true,false )
             ,new CursorDef("H00523", "SELECT COUNT(*) FROM ((([SEG004] T1 WITH (NOLOCK) INNER JOIN [SEG000] T3 WITH (NOLOCK) ON T3.[SIS_COD] = T1.[SIS_COD]) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[USU_COD]) INNER JOIN [SEG001] T4 WITH (NOLOCK) ON T4.[PRG_COD] = T1.[PRG_COD]) WHERE T1.[USU_COD] = @AV5USUCOD and T1.[SIS_COD] = @AV9SISCOD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00523,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 16) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 3) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
       }
    }

 }

}
