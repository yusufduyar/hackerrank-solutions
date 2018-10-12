require './lib/counting_valleys.rb'
require 'test/unit'

class TestCountingValleys < Test::Unit::TestCase
  def test_should_return_1
    number_of_steps = 8
    path = 'UDDDUDUU'
    expected_valley_count = 1

    actual_valley_count = Solution.new.counting_valleys(number_of_steps, path)

    assert_equal(expected_valley_count, actual_valley_count)
  end

  def test_should_return_2
    number_of_steps = 12
    path = 'DDUUDDUDUUUD'
    expected_valley_count = 2

    actual_valley_count = Solution.new.counting_valleys(number_of_steps, path)

    assert_equal(expected_valley_count, actual_valley_count)
  end

  def test_should_return_0
    number_of_steps = 10
    path = 'UDUUUDUDDD'
    expected_valley_count = 0

    actual_valley_count = Solution.new.counting_valleys(number_of_steps, path)

    assert_equal(expected_valley_count, actual_valley_count)
  end
end
