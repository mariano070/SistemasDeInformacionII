/*
               File: HSEG006
        Description: Genera Usuario copiando otro
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/29/2014 16:18:30.32
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
   public class hseg006 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hseg006( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hseg006( IGxContext context )
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

      public void execute( ref String aP0_USUNCD ,
                           ref String aP1_USUNDE ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV6USUNCD = aP0_USUNCD;
         this.AV10USUNDE = aP1_USUNDE;
         this.AV8SISTEMA = aP2_SISTEMA;
         this.AV7USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_USUNCD=this.AV6USUNCD;
         aP1_USUNDE=this.AV10USUNDE;
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
               AV6USUNCD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUNCD", AV6USUNCD);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV10USUNDE = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUNDE", AV10USUNDE);
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA502( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START502( ) ;
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
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;margin: 0px;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6USUNCD)) + "," + UrlEncode(StringUtil.RTrim(AV10USUNDE)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV8SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV7USUARIO));
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
            WE502( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT502( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "HSEG006" ;
      }

      public override String GetPgmdesc( )
      {
         return "Genera Usuario copiando otro" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6USUNCD)) + "," + UrlEncode(StringUtil.RTrim(AV10USUNDE)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO)) ;
      }

      protected void WB500( )
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
            wb_table1_3_502( true) ;
         }
         else
         {
            wb_table1_3_502( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_502e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</pre>") ;
         }
         wbLoad = true ;
      }

      protected void START502( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Genera Usuario copiando otro", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP500( ) ;
      }

      protected void WS502( )
      {
         START502( ) ;
         EVT502( ) ;
      }

      protected void EVT502( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'USUARIO'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11502 */
                              E11502 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'SISTEMAS Y PROGRAMAS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12502 */
                              E12502 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false ;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: E13502 */
                                    E13502 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E14502 */
                              E14502 ();
                              /* No code required for Cancel button. It is implemented as the Reset button. */
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
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE502( )
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

      protected void PA502( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavUsucod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF502( ) ;
         /* End function Refresh */
      }

      protected void RF502( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E14502 */
            E14502 ();
            WB500( ) ;
         }
      }

      protected void STRUP500( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavUsudes_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsudes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsudes_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6USUNCD = StringUtil.Upper( cgiGet( edtavUsuncd_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUNCD", AV6USUNCD);
            AV10USUNDE = StringUtil.Upper( cgiGet( edtavUsunde_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUNDE", AV10USUNDE);
            AV5USUCOD = StringUtil.Upper( cgiGet( edtavUsucod_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUCOD", AV5USUCOD);
            AV9USUDES = StringUtil.Upper( cgiGet( edtavUsudes_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USUDES", AV9USUDES);
            /* Read saved values. */
            AV8SISTEMA = cgiGet( "vSISTEMA") ;
            AV7USUARIO = cgiGet( "vUSUARIO") ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E11502( )
      {
         /* 'Usuario' Routine */
         context.wjLoc = formatLink("hseg007.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5USUCOD)) + "," + UrlEncode(StringUtil.RTrim(AV9USUDES)) ;
      }

      protected void E12502( )
      {
         /* 'Sistemas y Programas' Routine */
         context.wjLoc = formatLink("hseg005.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5USUCOD)) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E13502 */
         E13502 ();
         if (returnInSub) return;
      }

      protected void E13502( )
      {
         /* Enter Routine */
         new pseg006(context ).execute( ref  AV5USUCOD, ref  AV6USUNCD) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUCOD", AV5USUCOD);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUNCD", AV6USUNCD);
         context.setWebReturnParms(new Object[] {(String)AV6USUNCD,(String)AV10USUNDE,(String)AV8SISTEMA,(String)AV7USUARIO});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void nextLoad( )
      {
      }

      protected void E14502( )
      {
         /* Load Routine */
      }

      protected void wb_table1_3_502( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Nuevo Usuario:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HSEG006.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavUsuncd_Internalname, StringUtil.RTrim( AV6USUNCD), "", 16, "chr", 1, "row", 16, 1, edtavUsuncd_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6USUNCD, "@!")), "", 0, edtavUsuncd_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG006.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavUsunde_Internalname, StringUtil.RTrim( AV10USUNDE), "", 50, "chr", 1, "row", 50, 1, edtavUsunde_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10USUNDE, "@!")), "", 0, edtavUsunde_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Copiar desde Usuario:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HSEG006.htm");
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavUsucod_Internalname, StringUtil.RTrim( AV5USUCOD), "", 16, "chr", 1, "row", 16, 1, edtavUsucod_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV5USUCOD, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(12);\"", 0, edtavUsucod_Jsonclick, "", 0, 1, 1, true, "left", "HLP_HSEG006.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavUsudes_Internalname, StringUtil.RTrim( AV9USUDES), "", 50, "chr", 1, "row", 50, 1, edtavUsudes_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9USUDES, "@!")), "", 0, edtavUsudes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_16_502( true) ;
         }
         else
         {
            wb_table2_16_502( false) ;
         }
         return  ;
      }

      protected void wb_table2_16_502e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_502e( true) ;
         }
         else
         {
            wb_table1_3_502e( false) ;
         }
      }

      protected void wb_table2_16_502( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton2_Internalname, "Sistemas y Programas", "Sistemas y Programas", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton2_Jsonclick, "E\\'SISTEMAS Y PROGRAMAS\\'.", TempTags, "", "", "HLP_HSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton3_Internalname, "Confirma", "Confirma", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton3_Jsonclick, "EENTER.", TempTags, "", "", "HLP_HSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Salir", "Salir", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_HSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_16_502e( true) ;
         }
         else
         {
            wb_table2_16_502e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6USUNCD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUNCD", AV6USUNCD);
         AV10USUNDE = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUNDE", AV10USUNDE);
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
         PA502( ) ;
         WS502( ) ;
         WE502( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?15564175");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?16183050");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("hseg006.js", "?16183050");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavUsuncd_Internalname = "vUSUNCD" ;
         edtavUsunde_Internalname = "vUSUNDE" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavUsucod_Internalname = "vUSUCOD" ;
         edtavUsudes_Internalname = "vUSUDES" ;
         bttButton2_Internalname = "BUTTON2" ;
         bttButton3_Internalname = "BUTTON3" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable1_Internalname = "TABLE1" ;
         tblTable2_Internalname = "TABLE2" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavUsudes_Jsonclick = "" ;
         edtavUsudes_Backstyle = -1 ;
         edtavUsudes_Backcolor = (int)(0xFFFFFF) ;
         edtavUsudes_Enabled = 0 ;
         edtavUsucod_Jsonclick = "" ;
         edtavUsucod_Backstyle = -1 ;
         edtavUsucod_Backcolor = (int)(0xFFFFFF) ;
         edtavUsucod_Enabled = 1 ;
         edtavUsunde_Jsonclick = "" ;
         edtavUsunde_Backstyle = -1 ;
         edtavUsunde_Backcolor = (int)(0xFFFFFF) ;
         edtavUsunde_Enabled = 0 ;
         edtavUsuncd_Jsonclick = "" ;
         edtavUsuncd_Backstyle = -1 ;
         edtavUsuncd_Backcolor = (int)(0xFFFFFF) ;
         edtavUsuncd_Enabled = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Genera Usuario copiando otro" ;
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
         wcpOAV6USUNCD = "" ;
         wcpOAV10USUNDE = "" ;
         wcpOAV8SISTEMA = "" ;
         wcpOAV7USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV5USUCOD = "" ;
         AV9USUDES = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         TempTags = "" ;
         GXt_char3 = "" ;
         bttButton2_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short nGXWrapped ;
      private short edtavUsudes_Backstyle ;
      private short edtavUsucod_Backstyle ;
      private short edtavUsunde_Backstyle ;
      private short edtavUsuncd_Backstyle ;
      private int edtavUsudes_Enabled ;
      private int edtavUsuncd_Enabled ;
      private int edtavUsunde_Enabled ;
      private int edtavUsucod_Enabled ;
      private int idxLst ;
      private int edtavUsudes_Backcolor ;
      private int edtavUsucod_Backcolor ;
      private int edtavUsunde_Backcolor ;
      private int edtavUsuncd_Backcolor ;
      private String AV6USUNCD ;
      private String AV10USUNDE ;
      private String AV8SISTEMA ;
      private String AV7USUARIO ;
      private String wcpOAV6USUNCD ;
      private String wcpOAV10USUNDE ;
      private String wcpOAV8SISTEMA ;
      private String wcpOAV7USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUsucod_Internalname ;
      private String edtavUsudes_Internalname ;
      private String edtavUsuncd_Internalname ;
      private String edtavUsunde_Internalname ;
      private String AV5USUCOD ;
      private String AV9USUDES ;
      private String sStyleString ;
      private String tblTable2_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavUsuncd_Jsonclick ;
      private String edtavUsunde_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String TempTags ;
      private String GXt_char3 ;
      private String edtavUsucod_Jsonclick ;
      private String edtavUsudes_Jsonclick ;
      private String tblTable1_Internalname ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_USUNCD ;
      private String aP1_USUNDE ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

}
