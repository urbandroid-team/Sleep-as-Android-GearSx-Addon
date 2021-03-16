package com.urbandroid.sleep.addon.generic.samsung;

import java.util.regex.Pattern;

class DataConverter {

    static String[] convertToCorrectDataFormat(String receivedData) throws InconvertibleDataFormatException {
        Pattern correctNewPattern = Pattern.compile("^(?:\\d+\\.\\d+,0,0,\\d+\\.\\d+,?)+");
        Pattern correctOldPattern = Pattern.compile("^(?:\\d+\\.\\d+,\\d+\\.?\\d*,\\d+\\.?\\d*,\\d+\\.\\d+,?)+");
        Pattern decimalCommaPattern = Pattern.compile("^(?:\\d+,\\d+,0,0,\\d+,\\d+,?)+");
        Pattern decimalCommaOldPattern = Pattern.compile("^(?:\\d+,\\d+,\\d+,\\d+,\\d+,\\d+,\\d+,\\d+,?)+");

        if (correctNewPattern.matcher(receivedData).matches() || correctOldPattern.matcher(receivedData).matches()) {
            return receivedData.split(",");
        } else if (decimalCommaPattern.matcher(receivedData).matches()) {
            // Data are in wrong locale - floats use decimal comma instead of decimal point
            return convertDecimalCommaDataToPointData(receivedData).split(",");
        } else if (decimalCommaOldPattern.matcher(receivedData).matches() ){
            // Data are in wrong locale - floats use decimal comma instead of decimal point
            return convertDecimalOldCommaDataToPointData(receivedData).split(",");
        } else {
            throw new InconvertibleDataFormatException("Wrong data format received");
        }
    }

    private static String convertDecimalCommaDataToPointData(String input) {
        char[] chars = input.toCharArray();
        int counter = 6;
        for (int i = 0; i < chars.length; i++){
            if (chars[i] == (",").charAt(0)) {
                if (counter == 6 || counter == 2) {
                    chars[i] = '.';
                }
                counter--;
                if (counter <= 0 ) { counter = 6; }
            }
        }
        return String.valueOf(chars);
    }

    private static String convertDecimalOldCommaDataToPointData(String input) {
        char[] chars = input.toCharArray();
        int counter = 8;
        for (int i = 0; i < chars.length; i++){
            if (chars[i] == (",").charAt(0)) {
                if (counter%2 == 0) {
                    chars[i] = '.';
                }
                counter--;
                if (counter <= 0 ) { counter = 6; }
            }
        }
        return String.valueOf(chars);
    }

}
